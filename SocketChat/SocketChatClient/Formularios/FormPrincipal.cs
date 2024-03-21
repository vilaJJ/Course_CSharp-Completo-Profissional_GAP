using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketChatClient.Formularios
{
    public partial class FormPrincipal : Form
    {
        /// <summary>
        /// Trata o nome do usuário.
        /// </summary>
        private string NomeUsuario { get; set; }
        private StreamWriter Enviador { get; set; }
        private StreamReader Receptor { get; set; }
        private TcpClient TcpServidor { get; set; }

        /// <summary>
        /// Necessário para atualizar o formulário com mensagens de outra thread.
        /// </summary>
        /// <param name="mensagem">Mensagem a ser exibida.</param>
        private delegate void AtualizaLogCallback(string mensagem);

        /// <summary>
        /// Necessário para definir o formulário para o estado <i>disconnected</i> de outra thread.
        /// </summary>
        /// <param name="motivo">Mensagem a ser exibida.</param>
        private delegate void FechaConexaoCallback(string motivo);

        private Thread ThreadServico { get; set; }
        private IPAddress EnderecoIP { get; set; }
        private int PortaHost { get; set; }
        private bool Conectado { get; set; }

        public FormPrincipal()
        {
            // Na saida da aplicação == desconectar
            Application.ApplicationExit += new EventHandler(OnApplicationExit);

            InitializeComponent();
        }

        private void Button_EnviarMensagem_Click(object sender, EventArgs e)
        {
            EnviarMensagem();
        }

        private void Button_Conectar_Click(object sender, EventArgs e)
        {
            // Se não está conectado, aguarda conexão

            if (Conectado)
            {
                // Se está conectado, desconectar
                FecharConexao("Desconectado pelo usuário.");
            }
            else
            {
                // Inicializa a conexão
                InicializarConexao();
            }
        }

        private void TextBox_Mensagem_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Se pressionou Enter, enviar mensagem

            if (e.KeyChar == (char)13)
            {
                EnviarMensagem();
            }
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            if (Conectado)
            {
                AtualizarStatusConectado(false);
                LiberarRecursos();
            }
        }

        private void InicializarConexao()
        {
            try
            {
                // Trata o endereço IP e Porta informado
                EnderecoIP = IPAddress.Parse(TextBox_EnderecoIP.Text.Trim());
                PortaHost = (int)NumericUpDown_Porta.Value;

                // Inicia uma nova conexão TCP com o servidor Chat
                TcpServidor = new TcpClient();
                TcpServidor.Connect(EnderecoIP, PortaHost);

                // Informa que está conectado
                AtualizarStatusConectado(true, false);

                // Prepara o formulário
                NomeUsuario = TextBox_NomeUsuario.Text;

                // Envia o nome do usuário para o servidor.
                Enviador = new StreamWriter(TcpServidor.GetStream());
                EnviarMensagem(TextBox_NomeUsuario.Text);

                // Inicia a Thread para receber mensagem e nova comunicação
                ThreadServico = new Thread(new ThreadStart(ReceberMensagem))
                {
                    IsBackground = true
                };
                ThreadServico.Start();
            }
            catch (Exception ex)
            {
                AtualizarStatusConectado(false);
                ExibirMensagemErro("Erro ao inicializar conexão.\n\n" + ex.Message);
            }
        }

        private void ReceberMensagem()
        {
            // Recebe a resposta do servidor
            Receptor = new StreamReader(TcpServidor.GetStream());
            var resposta = Receptor.ReadLine();

            var sucesso = resposta[0] == '1';

            // Se o primeiro caracter da resposta é 1, a conexão foi feita com sucesso.
            if (sucesso)
            {
                // Atualiza o formulário para informar que está conectado
                AtualizarLogInvoke("Conectado com sucesso.");
            }
            else
            {
                // Se o primeiro caracter não for 1, a conexão falhou
                var motivo = string.Format(
                    "Não conectado: {0}",
                    resposta.Substring(2)
                    );
                FecharConexaoInvoke(motivo);

                return;
            }

            AtualizarStatusConectado(sucesso);

            while (Conectado)
            {
                try
                {
                    // Exibir as mensagens no log de mensagens
                    AtualizarLogInvoke(Receptor.ReadLine());
                }
                catch (Exception ex)
                {
                    if (TcpServidor.Connected)
                    {
                        ExibirMensagemErro("Erro na conexão.\n\n" + ex.Message);
                        Application.Exit();
                    }
                    else
                    {
                        AtualizarStatusConectado(false);
                    }
                }                
            }
        }

        private void AtualizarLogInvoke(string mensagem)
        {
            Invoke(new AtualizaLogCallback(AtualizarLog), new object[] { mensagem });
        }

        private void AtualizarLog(string mensagem)
        {
            // Anexa o texto ao final de cada linha
            RealizarAppendNoLog(mensagem + "\r\n");
        }

        private void EnviarMensagem()
        {
            // Enivar mensagem pro servidor
            if (TextBox_Mensagem.Lines.Length > 0)
            {
                EnviarMensagem(TextBox_Mensagem.Text);
                TextBox_Mensagem.Lines = null;
            }
            TextBox_Mensagem.Clear();
        }

        private void EnviarMensagem(string mensagem)
        {
            Enviador.WriteLine(mensagem.Trim());
            Enviador.Flush();
        }

        private void FecharConexaoInvoke(string motivo)
        {
            Invoke(new FechaConexaoCallback(FecharConexao), new object[] { motivo });
        }

        private void FecharConexao(string motivo)
        {
            // Fecha a conexão com o servidor
            // Mostrar o motivo do porque a conexão encerrou
            RealizarAppendNoLog(motivo + "\r\n");

            // Atualizar o status dos componentes visuais
            AtualizarStatusConectado(false);

            // Encerra e libera recursos de objetos de leitura/escrita
            LiberarRecursos();
        }

        private void ExibirMensagemErro(string mensagem)
        {
            MessageBox.Show(
                mensagem,
                "Erro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Stop
                );
        }

        private void AtualizarStatusConectado(bool value, bool statusConcretizado = true)
        {
            Conectado = value;

            Invoke(new Action(() =>
            {
                TextBox_EnderecoIP.ReadOnly = 
                NumericUpDown_Porta.ReadOnly =
                TextBox_NomeUsuario.ReadOnly =
                value;

                TextBox_Mensagem.Enabled = 
                Button_EnviarMensagem.Enabled =
                value;

                if (statusConcretizado)
                {
                    Button_Conectar.ForeColor = value ? Color.Red : Color.Green;
                    Button_Conectar.Text = value ? "Des&conectar" : "&Conectar";

                    ToolStripStatusLabel_StatusConectado.Text = value ? "Conectado" : "Não conectado";
                    ToolStripStatusLabel_StatusConectado.ForeColor = value ? Color.DarkGreen : Color.Black;
                }                
            }));            
        }

        private void RealizarAppendNoLog(string value)
        {
            TextBox_MensagensRecebidas.AppendText(value + "\r\n");
        }

        private void LiberarRecursos()
        {
            Enviador.Close();
            Receptor.Close();
            TcpServidor.Close();
        }
    }
}

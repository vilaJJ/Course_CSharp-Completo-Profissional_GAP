using SocketChatServer.Classes;
using SocketChatServer.Eventos;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SocketChatServer.Formularios
{
    public partial class FormPrincipal : Form
    {
        private delegate void AtualizaStatusCallback(string mensagem);

        private bool Conectado { get; set; }

        public FormPrincipal()
        {
            InitializeComponent();

            Conectado = false;
        }

        private void Button_IniciarServidor_Click(object sender, EventArgs e)
        {
            ListBox_Logs.Items.Clear();

            if (Conectado)
            {
                Application.Exit();
                return;
            }

            if (string.IsNullOrEmpty(TextBox_EnderecoIP.Text.Trim()))
            {
                MessageBox.Show("Informe o endereço de IP.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                TextBox_EnderecoIP.Focus();
            }

            if (string.IsNullOrEmpty(NumericUpDown_Porta.Value.ToString().Trim()))
            {
                MessageBox.Show("Informe a porta.", "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                NumericUpDown_Porta.Focus();
            }

            try
            {
                var enderecoIP = TextBox_EnderecoIP.Text.Trim();
                var porta = (int)NumericUpDown_Porta.Value;

                // Cria uma nova instância do servidor.
                var chatServer = new ChatServer(enderecoIP, porta);

                // Vincula o tratamento de evento StatusChanged a ChatServer_StatusChanged.
                ChatServer.StatusChanged += new StatusChangedEventHandler(ChatServer_StatusChanged);

                // Inicia o atendimento das conexões
                chatServer.IniciarAtendimento();

                // Indica que o atendimento foi iniciado
                RegistrarLog("Servidor ativo. Atendimentos abertos.");
            }
            catch (Exception ex)
            {
                RegistrarLog("Erro: " + ex.Message);
            }

            Conectado = true;

            TextBox_EnderecoIP.Enabled = NumericUpDown_Porta.Enabled = false;

            Button_IniciarServidor.ForeColor = Color.Red;
            Button_IniciarServidor.Text = "Parar o &Servidor";
        }

        internal void ChatServer_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Chama o método que atualiza o formulário
            Invoke(new AtualizaStatusCallback(AtualizaStatus), new object[] { e.EventMessage });
        }

        private void AtualizaStatus(string mensagem)
        {
            RegistrarLog(mensagem);
        }

        private void RegistrarLog(string log)
        {
            // Atualiza o log de mensagens
            ListBox_Logs.Items.Add(log);
            ListBox_Logs.SetSelected(ListBox_Logs.Items.Count - 1, true);
        }
    }
}

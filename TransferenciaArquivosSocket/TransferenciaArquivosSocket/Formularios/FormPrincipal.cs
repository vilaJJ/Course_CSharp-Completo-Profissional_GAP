using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferenciaArquivosServer.Classes;

namespace TransferenciaArquivosServer.Formularios
{
    public partial class FormPrincipal : Form
    {
        private FTServer Servidor;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            InformarConexao();

            LinkLabel_SelecionarPasta.Text = Servidor.PathArquivos;
        }

        private void Button_EstabelecerConexao_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarInformacoes();
                InformarConexao();
                IniciarServidor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro ao iniciar servidor",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }            
        }

        private void Button_PararServidor_Click(object sender, EventArgs e)
        {
            PararServidor();
        }

        private void LinkLabel_SelecionarPasta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DefinirPastaDestino();
        }

        #region Métodos privados

        private void InformarConexao()
        {
            var enderecoIPInicial = TextBox_EnderecoIP.Text;
            var portaInicial = (int)NumericUpDown_Porta.Value;
            var pathArquivos = ObterPathSelecionado();

            Servidor = new FTServer(
                enderecoIPInicial,
                portaInicial,
                ListBox_Logs,
                pathArquivos: pathArquivos
                );
        }

        private void IniciarServidor()
        {
            Task.Factory.StartNew(() =>
            {
                try
                {
                    Servidor.Iniciar();
                }
                catch (Exception ex)
                {
                    Servidor.AdicionarMensagem("Erro na execuação da tarefa do servidor. " + ex.Message);
                }
            });
        }

        private void PararServidor()
        {
            try
            {
                Application.Restart();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Não foi possível parar o servidor. " + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void DefinirPastaDestino()
        {
            var dialogResult = FolderBrowserDialog_DestinoArquivos.ShowDialog();

            if (dialogResult != DialogResult.OK)
            {
                return;
            }

            var diretorioSelecionado = ObterPathSelecionado();
            Servidor.DefinirPathArquivos(diretorioSelecionado);

            LinkLabel_SelecionarPasta.Text = diretorioSelecionado;
        }

        private string ObterPathSelecionado()
        {
            var selectedPath = FolderBrowserDialog_DestinoArquivos.SelectedPath;

            if (string.IsNullOrEmpty(selectedPath))
            {
                return null;
            }

            return selectedPath + "\\";
        }

        private void ValidarInformacoes()
        {
            string erro;

            if (string.IsNullOrEmpty(TextBox_EnderecoIP.Text))
            {
                erro = "É necessário informar o endereço de IP do servidor.";
            }
            else if (string.IsNullOrEmpty(NumericUpDown_Porta.Value.ToString()))
            {
                erro = "É necessário informar a porta do servidor.";
            }
            else
            {
                erro = null;
            }

            if (erro is string)
            {
                throw new InvalidOperationException(erro);
            }
        }

        #endregion
    }
}

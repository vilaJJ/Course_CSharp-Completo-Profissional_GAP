using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferenciaArquivoCliente.Classes;
using TransferenciaArquivoCliente.Models;

namespace TransferenciaArquivoCliente.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void LinkLabel_SelecionarArquivo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SelecionarArquivo();
        }

        private void Button_EnviarArquivo_Click(object sender, EventArgs e)
        {
            EnviarArquivo();
        }

        #region Métodos Privados

        private void SelecionarArquivo()
        {
            var resultDialog = OpenFileDialog_SelecionarArquivo.ShowDialog();

            if (resultDialog == DialogResult.OK)
            {
                var arquivoSelecionado = ObterArquivoSelecionado();
                LinkLabel_SelecionarArquivo.Text = arquivoSelecionado;
            }
        }

        private string ObterArquivoSelecionado()
        {
            return OpenFileDialog_SelecionarArquivo.FileName;
        }

        private void EnviarArquivo()
        {
            try
            {
                ValidarInformacoes();

                var enderecoIP = TextBox_EnderecoIP.Text;
                var porta = (int)NumericUpDown_Porta.Value;
                var arquivo = ObterArquivoSelecionado();

                using (var socketClient = new FTClient(enderecoIP, porta))
                {
                    Task.Factory.StartNew(() =>
                    {
                        var resultado = socketClient.EnviarArquivo(arquivo);
                        DefinirLabel(resultado);
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro ao enviar arquivo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
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
            else if (string.IsNullOrEmpty(ObterArquivoSelecionado()))
            {
                erro = "É necessário selecionar um arquivo para envio.";
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

        private void DefinirLabel(EnvioResultModel resultado)
        {
            Label_Status.Invoke(new Action(() =>
            {
                Label_Status.ForeColor =
                resultado.Sucesso
                ? Color.FromArgb(0, 110, 91)
                : Color.Red;

                Label_Status.Text = resultado.Mensagem;
            }));            
        }

        #endregion
    }
}

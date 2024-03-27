using CriptografarArquivos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CriptografarArquivos.Formularios
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            Criptografia.ParametrosCsp = new CspParameters();

            Criptografia.PastaParaCriptografados = GetFolderPath(SpecialFolder.MyDocuments) + "\\Criptografados\\";
            Criptografia.DestinoDescriptografados = GetFolderPath(SpecialFolder.MyDocuments) + "\\Descriptografados\\";
            Criptografia.PastaOrigem = GetFolderPath(SpecialFolder.MyDocuments);
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            OpenFileDialog_SelecionarArquivo.InitialDirectory = Criptografia.PastaOrigem;
        }

        private void Button_CriptografarArquivo_Click(object sender, EventArgs e)
        {
            if (Criptografia.ProvedorCriptografiaRSA is null)
            {
                DefinirLabelStatus(false, "Chave não definida.");
                return;
            }

            var resultadoDialogo = OpenFileDialog_SelecionarArquivo.ShowDialog();

            if (resultadoDialogo != DialogResult.OK)
            {
                return;
            }

            var fileName = OpenFileDialog_SelecionarArquivo.FileName;
            var fileInfo = new FileInfo(fileName);
            var pathArquivo = fileInfo.FullName;

            var status = Criptografia.EncriptografarArquivo(pathArquivo);

            DefinirLabelStatus(true, status);
        }

        private void Button_DescriptografarArquivo_Click(object sender, EventArgs e)
        {
            if (Criptografia.ProvedorCriptografiaRSA is null)
            {
                DefinirLabelStatus(false, "Chave não definida.");
                return;
            }

            var resultadoDialogo = OpenFileDialog_SelecionarArquivo.ShowDialog();

            if (resultadoDialogo != DialogResult.OK)
            {
                return;
            }

            var fileName = OpenFileDialog_SelecionarArquivo.FileName;
            var fileInfo = new FileInfo(fileName);
            var nomeArquivo = fileInfo.Name;

            var status = Criptografia.DescriptografarArquivo(nomeArquivo);

            DefinirLabelStatus(true, status);
        }

        private void Button_CriarChaves_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_Chave.Text.Trim()))
            {
                DefinirLabelStatus(false, "Insira um valor para definir a chave pública.");
                TextBox_Chave.Focus();
                return;
            }

            Criptografia.NomeChave = TextBox_Chave.Text.Trim();
            
            var status = Criptografia.CriarChaveAssimetrica();

            DefinirLabelStatus(true, status);
        }

        private void Button_ImportarChavePublica_Click(object sender, EventArgs e)
        {
            Criptografia.NomeChave = "Pública";

            var statusOperacao = Criptografia.ImportarChavePublica();
            DefinirLabelStatus(true, statusOperacao);
        }

        private void Button_ExportarChavePublica_Click(object sender, EventArgs e)
        {
            var exportado = Criptografia.ExportarChavePublica();

            DefinirLabelStatus(
                exportado, 
                exportado 
                    ? "Chave pública exportada." 
                    : "Não foi possivel exportar a chave pública."
                );
        }

        private void Button_ObterChavePrivada_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBox_Chave.Text.Trim()))
            {
                DefinirLabelStatus(false, "Insira um valor para definir a chave privada.");
                TextBox_Chave.Focus();
                return;
            }

            Criptografia.NomeChave = TextBox_Chave.Text.Trim();

            var status = Criptografia.ObterChavePrivada();

            DefinirLabelStatus(true, status);
        }

        private void DefinirLabelStatus(bool status, string mensagem)
        {
            Label_Status.Invoke(new Action(() =>
            {
                Label_Status.ForeColor = status ? Color.Black : Color.Red;
                Label_Status.Text = mensagem;
            }));
        }
    }
}

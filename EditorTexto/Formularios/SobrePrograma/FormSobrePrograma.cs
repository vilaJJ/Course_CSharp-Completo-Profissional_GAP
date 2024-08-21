using System.Diagnostics;

namespace EditorTexto.Formularios.SobrePrograma
{
    public partial class FormSobrePrograma : Form
    {
        #region Propriedades

        private string CaminhoExecutavel
        {
            get
            {
                return Application.ExecutablePath;
            }
        }

        private DateTime DataAlteracao
        {
            get
            {
                return File.GetLastWriteTime(CaminhoExecutavel);
            }
        }

        private string? Versao
        {
            get
            {
                return FileVersionInfo.GetVersionInfo(CaminhoExecutavel).FileVersion;
            }
        }

        #endregion

        #region Construtores

        public FormSobrePrograma()
        {
            InitializeComponent();
        }

        #endregion

        #region Form Events

        private void FormSobrePrograma_Load(object sender, EventArgs e)
        {
            string dataAlteracao = DataAlteracao.ToString("dd/MM/yyyy HH:mm:ss");
            string versao = Versao ?? "Versão não identificada";

            Label_DataVersao.Text = dataAlteracao;
            Label_Versao.Text = versao;
        }

        #endregion
    }
}

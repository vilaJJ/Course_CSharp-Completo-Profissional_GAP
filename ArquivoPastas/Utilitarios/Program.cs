using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilitarios
{
    public class Alertas
    {
        static void Main(string[] args) { }

        public static void MensagemInformacao(string mensagem)
        {
            MessageBox.Show(
                mensagem,
                "Informação",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }        
    }

    public class Dispose
    {
        public static void StreamWriter(StreamWriter sw)
        {
            sw.Flush();
            sw.Dispose();
            sw.Close();
        }

        public static void StreamReader(StreamReader sr)
        {
            sr.Dispose();
            sr.Close();
        }

        public static void BinaryWriter(BinaryWriter bw)
        {
            bw.Flush();
            bw.Dispose();
            bw.Close();
        }
        public static void BinaryReader(BinaryReader br)
        {
            br.Dispose();
            br.Close();
        }
    }
}

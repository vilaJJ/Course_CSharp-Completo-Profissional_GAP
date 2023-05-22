using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LerEscrever
{
    public partial class Form1 : Form
    {
        readonly string path1 = @"C:\Users\NSYS-DEV-05\Desktop\File.txt";
        readonly string path2 = @"C:\Users\NSYS-DEV-05\Desktop\Files.txt";
        byte[] buffer;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_WriteTxt_Click(object sender, EventArgs e)
        {            
            StreamWriter writer = new StreamWriter(path1, false, Encoding.UTF8);

            try
            {
                // writer.WriteLine(textBox_Conteudo.Text);
                writer.Write(textBox_Conteudo.Text);                

                Utilitarios.Alertas.MensagemInformacao("Arquivo escrito.");
                textBox_Conteudo.Clear();
            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }
            finally
            {
                Utilitarios.Dispose.StreamWriter(writer);
            }
        }

        private void Button_ReadTxt_Click(object sender, EventArgs e)
        {
            textBox_Conteudo.Clear();
            
            try
            {
                StreamReader reader = new StreamReader(path1, Encoding.UTF8);

                string txt = reader.ReadToEnd();
                // string linha = reader.ReadLine();

                textBox_Conteudo.Text = txt;
                // textBox_Conteudo.Text = linha;

                Utilitarios.Dispose.StreamReader(reader);
            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }  
            

            /*
            try
            {
                StreamReader reader = new StreamReader(path1, Encoding.UTF8);

                while (!(reader.EndOfStream))
                {
                    textBox_Conteudo.Text += (char)reader.Read();
                }                

                Utilitarios.Dispose.StreamReader(reader);
            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }
            */
        }

        private void Button_Limpar_Click(object sender, EventArgs e)
        {
            if (textBox_Conteudo.Text != null || textBox_Conteudo.Text != "")
            {
                textBox_Conteudo.Clear();
                Utilitarios.Alertas.MensagemInformacao("Textbox limpa.");
            }
        }

        private void Button_ReadBin_Click(object sender, EventArgs e)
        {
            textBox_Conteudo.Clear();
            /*
            try
            {
                FileStream input = File.OpenRead(path1);
                BinaryReader reader = new BinaryReader(input, Encoding.UTF8);

                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    byte b = reader.ReadByte();
                    textBox_Conteudo.Text += (char)b;
                }

                Utilitarios.Dispose.BinaryReader(reader);
            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }
            */

            try
            {
                FileStream input = File.OpenRead(path1);
                BinaryReader reader = new BinaryReader(input, Encoding.UTF8);

                // buffer = reader.ReadBytes((int)reader.BaseStream.Length);
                buffer = File.ReadAllBytes(path1);

                foreach (byte b in buffer)
                {
                    textBox_Conteudo.Text += (char)b;
                }

                Utilitarios.Dispose.BinaryReader(reader);
            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }
        }

        private void Button_WriteBin_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream input = File.OpenWrite(path2);
                BinaryWriter writer = new BinaryWriter(input);

                writer.Write(buffer);

                Utilitarios.Dispose.BinaryWriter(writer);
            }
            catch (Exception ex)
            {
                Utilitarios.Alertas.MensagemInformacao(ex.Message);
            }
        }
    }
}

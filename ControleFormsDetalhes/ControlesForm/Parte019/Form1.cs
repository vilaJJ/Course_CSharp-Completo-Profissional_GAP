using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            /*
            string node = treeView1.SelectedNode.Text;
            Utilitarios.Alertas.MensagemInformacao($"Node: {node}.");
            */
        }

        private void MontarTreeView()
        {
            treeView1.BeginUpdate();

            treeView1.Nodes.Add("Nomes");
                treeView1.Nodes[0].Nodes.Add("Bárbara Ohana");
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Dados Pessoais");
                    treeView1.Nodes[0].Nodes[0].Nodes.Add("Dados Profissionais");

                treeView1.Nodes[0].Nodes.Add("Juan Felipe");

                treeView1.Nodes[0].Nodes.Add("Maria Eduarda");

                treeView1.Nodes[0].Nodes.Add("Yasmin Garcia");

            treeView1.EndUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MontarTreeView();
        }
    }
}

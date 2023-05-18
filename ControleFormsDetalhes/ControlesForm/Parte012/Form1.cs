using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parte012
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Executar_Click(object sender, EventArgs e)
        {
            DateTime data = monthCalendar.TodayDate;
            Utilitarios.Alertas.MensagemInformacao(data.ToString("dd/MM/yyyy"));
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            Utilitarios.Alertas.MensagemInformacao(monthCalendar.TodayDate.ToString("dd/MM/yyyy"));
        }
    }
}

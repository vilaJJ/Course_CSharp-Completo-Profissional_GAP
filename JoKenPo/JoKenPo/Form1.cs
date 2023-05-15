using JoKenPo.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class JogoMain : Form
    {
        public JogoMain()
        {
            InitializeComponent();
        }

        private void button_pedra_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void button_papel_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void button_tesoura_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void StartGame(int opcao)
        {
            label_resultado.Visible = false;

            Game jogo = new Game();

            switch (jogo.Jogar(opcao))
            {
                case Game.Resultado.Vitoria:
                    pictureBox_resultado.BackgroundImage = Image.FromFile("Assets/Vitoria.png");
                    goto default;
                case Game.Resultado.Empate:
                    pictureBox_resultado.BackgroundImage = Image.FromFile("Assets/Empate.png");
                    goto default;
                case Game.Resultado.Derrota:
                    pictureBox_resultado.BackgroundImage = Image.FromFile("Assets/Derrota.png");
                    goto default;
                default:
                    pictureBox_jogador.Image = jogo.ImgJogador;
                    pictureBox_computador.Image = jogo.ImgPC;
                    break;
            }
        }
    }
}

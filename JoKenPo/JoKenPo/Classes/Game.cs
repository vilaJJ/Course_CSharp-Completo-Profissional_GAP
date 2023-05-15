using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo.Classes
{
    class Game
    {
        public enum Resultado
        {
            Vitoria, Empate, Derrota
        }

        public static Image[] Imagens =
        {
            Image.FromFile("Assets/Pedra.png"),
            Image.FromFile("Assets/Papel.png"),
            Image.FromFile("Assets/Tesoura.png")
        };

        public Image ImgPC { get; private set; }
        public Image ImgJogador { get; private set; }

        public Resultado Jogar(int jogador)
        {
            int pc = JogadaPC();

            ImgPC = Imagens[pc];
            ImgJogador = Imagens[jogador];

            if((jogador == 0 && pc == 2) || (jogador == 1 && pc == 0) || (jogador == 2 && pc == 1)) 
            {
                return Resultado.Vitoria;
            }
            else if (jogador == pc)
            {
                return Resultado.Empate;
            }
            else
            {
                return Resultado.Derrota;
            }            
        }

        private int JogadaPC()
        {
            int mili = DateTime.Now.Millisecond;

            if (mili < 333)
            {
                return 0;
            }
            else if(mili >= 333 && mili < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
    }
}

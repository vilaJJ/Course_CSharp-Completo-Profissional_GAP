using VolumeCilindro.Exceptions;

namespace VolumeCilindro.Classes
{
    internal static class VolumeCilindro
    {
        #region Propriedades

        private const double PI = Math.PI;

        #endregion

        #region Métodos Internos

        internal static void RealizarDialogoCalcular()
        {
            try
            {
                double raio, altura, area, volume;

                raio = ObterValor("Digite o valor do raio da base do cilindro: ");
                altura = ObterValor("Digite o valor da altura do cilindro: ");
                area = CalcularArea(raio);
                volume = CalcularVolume(area, altura);

                ExibirResultado(volume);
            }
            catch (Exception ex)
            {
                ExibirMensagemConsole(ex.Message);
            }            
        }

        #endregion

        #region Cálculos

        private static double CalcularArea(double raio)
        {
            const double pi = PI;
            double raioQuadrado = CalcularPotencia(valorBase: raio, expoente: 2);

            return pi * raioQuadrado;
        }

        private static double CalcularVolume(double area, double altura)
        {
            return area * altura;
        }

        private static double CalcularPotencia(double valorBase, double expoente)
        {
            return Math.Pow(valorBase, expoente);
        }

        #endregion

        #region Exibir dados

        private static void ExibirResultado(double volume)
        {
            ExibirMensagemConsole($"Volume do cilindro: {volume}");
        }

        #endregion

        #region Formatar console

        private static void ExibirMensagemConsole(string mensagem)
        {
            Console.Write(mensagem);
        }

        private static void PularLinhaConsole()
        {
            Console.WriteLine();
        }

        #endregion

        #region Obtenção de valores

        private static double ObterValor(string mensagem)
        {
            int tentativas = 3;

            while (tentativas is not 0)
            {
                try
                {
                    ExibirMensagemConsole(mensagem);

                    double valor = ObterValorConsole();
                    ValidarValor(valor);
                    
                    return valor;
                }
                catch (ValorInvalidoException ex)
                {
                    ExibirMensagemConsole($"{ex.Message}\nTente novamente.\n");
                }
                catch (Exception)
                {
                    ExibirMensagemConsole("Não foi possível obter os dados.\nTente novamente.\n");
                }
                finally
                {
                    PularLinhaConsole();
                }

                tentativas--;
            }

            throw new TentativasEsgotadasException();
        }

        private static double ObterValorConsole()
        {
            string? insercao = Console.ReadLine();
            return Convert.ToDouble(insercao);
        }

        #endregion

        #region Validações

        private static void ValidarValor(double valor)
        {
            bool isValido = valor > 0;

            if (isValido is false)
            {
                throw new ValorInvalidoException();
            }
        }

        #endregion
    }
}

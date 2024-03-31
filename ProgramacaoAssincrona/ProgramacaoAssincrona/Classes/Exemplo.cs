using ProgramacaoAssincrona.Formularios;
using System;
using System.Threading.Tasks;

namespace ProgramacaoAssincrona.Classes
{
    internal class Exemplo : IDisposable
    {
        internal void TaskVoid() 
        {
            Task.Delay(2000);
            FormPrincipal.InserirResultado("Uma tarefa de 2 segundos foi executada.");
        }

        internal void TaskLongaDuracao()
        {
            var isAnoBissexto = IsAnoBissexto();

            var resultado = string.Format(
                "{0} {1} um ano bissexto!",
                DateTime.Now.Year,
                isAnoBissexto ? "é" : "não é"
                );

            FormPrincipal.InserirResultado(resultado);
            TaskVoid();
        }

        private bool IsAnoBissexto()
        {
            return DateTime.IsLeapYear(DateTime.Now.Year);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

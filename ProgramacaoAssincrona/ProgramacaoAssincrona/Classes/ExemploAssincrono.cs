using ProgramacaoAssincrona.Formularios;
using System;
using System.Threading.Tasks;

namespace ProgramacaoAssincrona.Classes
{
    internal class ExemploAssincrono : IDisposable
    {
        internal async Task TaskVoid()
        {
            await Task.Delay(2000);
            FormPrincipal.InserirResultado("Uma tarefa de 2 segundos foi executada.");
        }

        internal async Task TaskLongaDuracao()
        {
            var isAnoBissexto = await IsAnoBissexto();

            var resultado = string.Format(
                "{0} {1} um ano bissexto!",
                DateTime.Now.Year,
                isAnoBissexto ? "é" : "não é"
                );

            FormPrincipal.InserirResultado(resultado);
            await TaskVoid();
        }

        private async Task<bool> IsAnoBissexto()
        {
            return await Task.FromResult(DateTime.IsLeapYear(DateTime.Now.Year));
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

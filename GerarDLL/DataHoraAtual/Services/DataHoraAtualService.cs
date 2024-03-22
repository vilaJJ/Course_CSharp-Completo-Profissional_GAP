using System;

namespace DataHoraAtual.Services
{
    public class DataHoraAtualService : IDisposable
    {
        public string ObterDataAtual()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

        public string ObterHoraAtual()
        {
            return DateTime.Now.ToString("HH:mm:ss");
        }

        public string ObterDataHoraAtual()
        {
            var dataAtual = ObterDataAtual();
            var horaAtual = ObterHoraAtual();

            return string.Format(
                "Data: {0}\n\nHora: {1}",
                dataAtual,
                horaAtual
                );
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

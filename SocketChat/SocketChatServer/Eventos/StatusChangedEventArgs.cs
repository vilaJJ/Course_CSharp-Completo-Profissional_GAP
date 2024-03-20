using System;

namespace SocketChatServer.Eventos
{
    /// <summary>
    /// Trata os argumentos para o evento <i>StatusChanged</i>.
    /// </summary>
    internal class StatusChangedEventArgs : EventArgs
    {
        /// <summary>
        /// Mensagem que descreve o evento.
        /// </summary>
        internal string EventMessage { get; private set; }

        /// <summary>
        /// Construtor para definir a mensagem do evento.
        /// </summary>
        /// <param name="eventMessage">Mensagem do evento.</param>
        internal StatusChangedEventArgs(string eventMessage)
        {
            EventMessage = eventMessage;
        }
    }
}

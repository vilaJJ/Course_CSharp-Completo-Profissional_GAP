namespace VolumeCilindro.Exceptions
{
    internal class ValorInvalidoException : Exception
    {
        #region Propriedades

        public override string Message => "O valor inserido não pode ser igual ou menor que zero.";

        #endregion

        #region Construtores

        internal ValorInvalidoException() : base() { }

        internal ValorInvalidoException(string mensagem) : base(mensagem) { }

        #endregion
    }
}

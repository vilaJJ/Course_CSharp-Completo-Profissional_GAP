namespace VolumeCilindro.Exceptions
{
    internal class TentativasEsgotadasException : Exception
    {
        #region Propriedades

        public override string Message => "Tentivas esgotadas. Não foi inserido um valor válido.";

        #endregion

        #region Construtores

        internal TentativasEsgotadasException() : base() { }

        internal TentativasEsgotadasException(string mensagem) : base(mensagem) { }

        #endregion
    }
}

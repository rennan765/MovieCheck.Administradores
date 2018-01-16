using System;

namespace MovieCheck.Administradores.Infra
{
    public class LockFailedException : Exception
    {
        public string Descricao { get; set; }

        public LockFailedException(string descricao)
        {
            this.Descricao = descricao;
        }
    }
}

using System;

namespace MovieCheck.Administradores
{
    public class NewUserFailedException : Exception
    {
        public string Desricao { get; set; }

        public NewUserFailedException(string descricao)
        {
            this.Desricao = descricao;
        }
    }
}
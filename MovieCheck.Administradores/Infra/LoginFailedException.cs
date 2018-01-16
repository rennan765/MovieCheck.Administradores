using System;

namespace MovieCheck.Administradores
{
    public class LoginFailedException : Exception
    {
        public string Desricao { get; set; }

        public LoginFailedException (string descricao)
        {
            this.Desricao = descricao;
        }
    }
}

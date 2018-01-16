using MovieCheck.Administradores.Modeling;
using System.Collections.Generic;
using System.Linq;

namespace MovieCheck.Administradores.Infra
{
    public static class CadastroUsuario
    {
        public static bool ValidaTelefone(int ddd, string telefone)
        {
            if (Telefone.IsValidDdd(ddd) && telefone != string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ValidaSenha(string senha, string senhaConfirma)
        {
            if (senha != senhaConfirma)
            {
                throw new NewUserFailedException("As senhas não correspondem. ");
            }
        }

        public static void AtualizaAdministrador(Cliente administrador)
        {
            Secao.Administrador.Nome = administrador.Nome;
            Secao.Administrador.Cpf = administrador.Cpf;
            Secao.Administrador.Email = administrador.Email;
            Secao.Administrador.Telefones = administrador.Telefones;
            Secao.Administrador.Endereco = administrador.Endereco;
        }

        public static void AtualizaAdministrador(this Cliente administrador, string senha)
        {
            Secao.Administrador.Nome = administrador.Nome;
            Secao.Administrador.Cpf = administrador.Cpf;
            Secao.Administrador.Email = administrador.Email;
            Secao.Administrador.Telefones = administrador.Telefones;
            Secao.Administrador.Endereco = administrador.Endereco;
            Secao.Administrador.CadastrarSenha(senha);
        }

        public static Telefone TrataTelefone(int tipo, int ddd, string numero)
        {
            if (Telefone.IsValidDdd(ddd))
            {
                if (numero != string.Empty)
                {
                    return new Telefone() { Tipo = tipo, Ddd = ddd, Numero = numero };
                }
                else
                {
                    throw new NewUserFailedException("DDD preenchido, porém número de telefone não preenchido.");
                }
            }
            else
            {
                throw new NewUserFailedException("DDD inválido.");
            }
        }
    }
}

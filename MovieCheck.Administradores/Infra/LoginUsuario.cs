using Microsoft.EntityFrameworkCore;
using MovieCheck.Administradores.Modeling;
using System.Linq;

namespace MovieCheck.Administradores.Infra
{
    public static class LoginUsuario
    {
        public static void EfetuarLogin(this Cliente recurso)
        {
            if (Usuario.IsEmail(recurso.Email))
            {
                if (recurso.Senha != string.Empty)
                {
                    using (var contexto = new MovieCheckContext())
                    {
                        var cliente = contexto.Cliente
                            .Include(ut => ut.Telefones).ThenInclude(t => t.Telefone)
                            .Include(e => e.Endereco)
                            .Where(u => u.Email == recurso.Email).FirstOrDefault();

                        if (!(cliente is null))
                        {
                            if (recurso.Senha == cliente.Senha)
                            {
                                if (cliente.Status == 1)
                                {
                                    if (cliente.Tipo == 1)
                                    {
                                        Secao.Administrador = (Cliente)cliente;
                                    }
                                    else
                                    {
                                        throw new LoginFailedException("Este usuário não é administrador. ");
                                    }
                                }
                                else
                                {
                                    throw new LoginFailedException("Este usuário está bloqueado ou ainda não foi autorizado.");
                                }
                            }
                            else
                            {
                                throw new LoginFailedException("Senha incorreta.");
                            }
                        }
                        else
                        {
                            throw new LoginFailedException("E-mail não cadastrado.");
                        }
                    }
                }
                else
                {
                    throw new LoginFailedException("A senha não foi preenchdia.");
                }
            }
            else
            {
                throw new LoginFailedException("E-mail inválido.");
            }
        }
    }
}

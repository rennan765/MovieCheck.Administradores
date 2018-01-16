using Microsoft.EntityFrameworkCore;
using MovieCheck.Administradores.Infra;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace MovieCheck.Administradores.Modeling
{
    public abstract class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; private set; }
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
        public IList<UsuarioTelefone> Telefones { get; set; }
        public int Status { get; set; }    //0 = A AUTORIZAR - 1 = DESBLOQUEADO - 2 - BLOQUEADO
        

        /********** FUNCTIONS **********/

        public static Boolean IsEmail(string email)
        {
            return Regex.IsMatch(email, "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$");
        }

        //CHANGE STATUS: THE FIRST IS FOR LOCK/UNLOCK AND THE SECOND IS FOR ALLOW
        public void ChangeStatus()
        {
            if (this.Status == 1)
            {
                this.Status = 2;
            }
            else
            {
                this.Status = 1;
            }
        }

        public void ChangeStatus(string operation)
        {
            if(this.Status == 0)
            {
                if (operation == "allow")
                {
                    this.Status = 1;
                }
                else
                {
                    this.Status = 2;
                }
            }
        }

        public static bool IsNumeric(string value)
        {
            bool isNumeric = true;
            char[] valueChars = value.ToCharArray();

            foreach (var valueChar in valueChars)
            {
                if (!char.IsDigit(valueChar))
                {
                    isNumeric = false;
                    break;
                }
            }

            return isNumeric;
        }

        private string HashPassword(string senha)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] hashBytes;
            using (HashAlgorithm hash = SHA1.Create())
            {
                hashBytes = hash.ComputeHash(encoding.GetBytes(senha));
            }

            StringBuilder hashValue = new StringBuilder(hashBytes.Length * 2);
            foreach (byte b in hashBytes)
            {
                hashValue.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);
            }

            return hashValue.ToString();
        }

        public void CadastrarSenha(string senha)
        {
            this.Senha = HashPassword(senha);
        }

        public string VerificarSenha(string senha)
        {
            return HashPassword(senha);
        }

        public void AdicionarTelefone(Telefone telefone)
        {
            Telefone fixo = this.ObterTelefoneFixo();
            Telefone celular = this.ObterTelefoneCelular();
            Telefone telefoneBd = null;
            using (var contexto = new MovieCheckContext())
            {
                telefoneBd = contexto.Telefone.Where(t => t.Tipo == telefone.Tipo && t.Ddd == telefone.Ddd && t.Numero == telefone.Numero).FirstOrDefault();
            }
            if (telefoneBd is null)
            {
                if (telefone.Tipo == 0)
                {
                    if (!(fixo is null))
                    {
                        RemoverTelefone(fixo);
                        this.Telefones.Add(new UsuarioTelefone() { Telefone = telefone });
                    }
                    else
                    {
                        this.Telefones.Add(new UsuarioTelefone() { Telefone = telefone });
                    }
                }
                else
                {
                    if (!(celular is null))
                    {
                        RemoverTelefone(celular);
                        this.Telefones.Add(new UsuarioTelefone() { Telefone = telefone });
                    }
                    else
                    {
                        this.Telefones.Add(new UsuarioTelefone() { Telefone = telefone });
                    }
                }
            }
            else
            {
                if (telefoneBd.Tipo == 0)
                {
                    if (!(fixo is null))
                    {
                        RemoverTelefone(fixo);
                        this.Telefones.Add(new UsuarioTelefone() { Telefone = telefoneBd });
                    }
                    else
                    {
                        this.Telefones.Add(new UsuarioTelefone() { Telefone = telefoneBd });
                    }
                }
                else
                {
                    if (!(celular is null))
                    {
                        RemoverTelefone(celular);
                        this.Telefones.Add(new UsuarioTelefone() { Telefone = telefoneBd });
                    }
                    else
                    {
                        this.Telefones.Add(new UsuarioTelefone() { Telefone = telefoneBd });
                    }
                }
            }
            //this.Telefones.Add(new UsuarioTelefone() { Telefone = telefone });
        }

        public void RemoverTelefone(Telefone telefone)
        {
            UsuarioTelefone removerTelefone = null;
            foreach (var t in this.Telefones)
            {
                if (t.Telefone.Equals(telefone))
                {
                    removerTelefone = t;
                }
            }
            this.Telefones.Remove(removerTelefone);

            using (var contexto = new MovieCheckContext())
            {
                var telefoneBanco = contexto.Telefone
                    .Include(ut => ut.Usuarios)
                    .ThenInclude(u => u.Usuario)
                    .Where(t => t.Tipo == telefone.Tipo && t.Ddd == telefone.Ddd && t.Numero == telefone.Numero).FirstOrDefault();

                if (telefoneBanco.Usuarios.Count == 0)
                {
                    contexto.Telefone.Remove(telefoneBanco);
                    contexto.SaveChanges();
                }
            }
        }

        public Telefone ObterTelefoneFixo()
        {
            Telefone fixo = null;

            foreach (var telefone in this.Telefones)
            {
                if (telefone.Telefone.Tipo == 0)
                {
                    fixo = telefone.Telefone;
                }
            }

            return fixo;
        }

        public Telefone ObterTelefoneCelular()
        {
            Telefone celular = null;

            foreach (var telefone in this.Telefones)
            {
                if (telefone.Telefone.Tipo == 1)
                {
                    celular = telefone.Telefone;
                }
            }

            return celular;
        }

        public void AdicionarEndereco(Endereco endereco)
        {
            this.Endereco = new Endereco()
            {
                Logradouro = endereco.Logradouro,
                Numero = endereco.Numero,
                Complemento = endereco.Complemento,
                Bairro = endereco.Bairro,
                Cidade = endereco.Cidade,
                Estado = endereco.Estado,
                Cep = endereco.Cep
            };
        }

        public void AlterarEndereco(Endereco endereco)
        {
            this.Endereco.Logradouro = endereco.Logradouro;
            this.Endereco.Numero = endereco.Numero;
            this.Endereco.Complemento = endereco.Complemento;
            this.Endereco.Bairro = endereco.Bairro;
            this.Endereco.Cidade = endereco.Cidade;
            this.Endereco.Estado = endereco.Estado;
            this.Endereco.Cep = endereco.Cep;
        }

        public void RemoverEndereco()
        {
            this.Endereco = null;
        }
    }
}
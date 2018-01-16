using Microsoft.EntityFrameworkCore;
using MovieCheck.Administradores.Infra;
using MovieCheck.Administradores.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieCheck.Administradores.Dao
{
    public class ClienteDao : IDao<Cliente>, IDisposable
    {
        private MovieCheckContext contexto;

        public ClienteDao()
        {
            this.contexto = new MovieCheckContext();
        }

        public IList<Cliente> ObterLista()
        {
            return contexto.Cliente.ToList();
        }

        public Cliente ObterPorEmail(string email)
        {
            return contexto
                .Cliente
                .Include(t => t.Telefones)
                .ThenInclude(ut => ut.Telefone)
                .Include(e => e.Endereco)
                .Where(u => u.Email == email)
                .FirstOrDefault();
        }

        public Cliente ObterPorid(int id)
        {
            return contexto.Cliente.Find(id);
        }

        public IList<Cliente> ObterPendenteAutorizacao()
        {
            return contexto.Cliente.Where(u => u.Status == 0).ToList();
        }

        public void Adicionar(Cliente cliente)
        {
            contexto.Cliente.Add(cliente);
            contexto.SaveChanges();
        }

        public void Alterar(Cliente cliente)
        {
            contexto.Cliente.Update(cliente);
            contexto.SaveChanges();
        }

        public void Remover(Cliente cliente)
        {
            contexto.Cliente.Remove(cliente);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using MovieCheck.Administradores.Infra;
using MovieCheck.Administradores.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieCheck.Administradores.Dao
{
    class DependenteDao : IDao<Dependente>, IDisposable
    {
        public MovieCheckContext contexto { get; set; }

        public DependenteDao()
        {
            contexto = new MovieCheckContext();
        }

        public IList<Dependente> ObterLista()
        {
            return contexto.Dependente.ToList();
        }

        public Dependente ObterPorid(int id)
        {
            return contexto.Dependente.Find(id);
        }

        public IList<Dependente> ObterPorCliente (Cliente cliente)
        {
            return contexto.Dependente.Where(d => d.Cliente.Equals(cliente)).ToList();
        }

        public Dependente ObterPorEmail(string email)
        {
            return contexto
                .Dependente
                .Include(t => t.Telefones)
                .ThenInclude(ut => ut.Telefone)
                .Include(e => e.Endereco)
                .Where(d => d.Email == email)
                .FirstOrDefault();
        }

        public IList<Cliente> ObterPendenteAutorizacao()
        {
            return contexto.Cliente.Where(u => u.Status == 0).ToList();
        }

        public void Adicionar(Dependente dependente)
        {
            contexto.Dependente.Add(dependente);
            contexto.SaveChanges();
        }

        public void Alterar(Dependente dependente)
        {
            contexto.Dependente.Update(dependente);
            contexto.SaveChanges();
        }

        public void Remover(Dependente dependente)
        {
            contexto.Dependente.Remove(dependente);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}

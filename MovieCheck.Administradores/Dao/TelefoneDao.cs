using System;
using System.Collections.Generic;
using MovieCheck.Administradores.Modeling;
using MovieCheck.Administradores.Infra;
using System.Linq;

namespace MovieCheck.Administradores.Dao
{
    public class TelefoneDao : IDao<Telefone>, IDisposable
    {
        private MovieCheckContext contexto { get; set; }

        public TelefoneDao()
        {
            contexto = new MovieCheckContext();
        }

        public IList<Telefone> ObterLista()
        {
            return contexto.Telefone.ToList();
        }

        public IList<Telefone> ObterListaPorTipo(char tipo)
        {
            return contexto.Telefone.Where(t => t.Tipo == tipo).ToList();
        }

        public Telefone ObterPorid(int id)
        {
            return contexto.Telefone.Find(id);
        }

        public Telefone ObterPorNumero(int ddd, string numero)
        {
            return contexto.Telefone.Where(t => t.Ddd == ddd && t.Numero == numero).FirstOrDefault();
        }

        public void Adicionar(Telefone telefone)
        {
            contexto.Telefone.Add(telefone);
            contexto.SaveChanges();
        }

        public void Alterar(Telefone telefone)
        {
            contexto.Telefone.Update(telefone);
            contexto.SaveChanges();
        }

        public void Remover(Telefone telefone)
        {
            contexto.Telefone.Remove(telefone);
            contexto.SaveChanges();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }
    }
}

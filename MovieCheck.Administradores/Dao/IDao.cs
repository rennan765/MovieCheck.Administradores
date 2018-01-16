using System.Collections.Generic;

namespace MovieCheck.Administradores.Dao
{
    interface IDao<T>
    {
        IList<T> ObterLista();
        T ObterPorid(int id);
        void Adicionar(T t);
        void Alterar(T t);
        void Remover(T t);
    }
}

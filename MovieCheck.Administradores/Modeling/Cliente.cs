using Microsoft.EntityFrameworkCore;
using MovieCheck.Administradores.Infra;
using System.Collections.Generic;
using System.Linq;

namespace MovieCheck.Administradores.Modeling
{
    public class Cliente : Usuario
    {
        public string Cpf { get; set; }
        public int Tipo { get; set; }  //0 = NORMAL - 1 = ADMINISTRADOR
        public IList<Dependente> Dependentes { get; set; }

        /********** CONSTRUCTORS **********/

        public Cliente()
        {
            this.Telefones = new List<UsuarioTelefone>();
            this.Dependentes = new List<Dependente>();
        }

        /********** FUNCTIONS **********/

    }
}

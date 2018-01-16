using System.Collections.Generic;

namespace MovieCheck.Administradores.Modeling
{
    public class Dependente : Usuario
    {
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        /********** CONSTRUCTORS **********/

        public Dependente()
        {
            this.Telefones = new List<UsuarioTelefone>();
        }
    }

}

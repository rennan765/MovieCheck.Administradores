using MovieCheck.Administradores.Modeling;
using System.Collections.Generic;

namespace MovieCheck.Administradores.Infra
{
    public static class Secao
    {
        public static Cliente Administrador { get; set; }
        public static IList<Estado> Estados { get; set; }
    }
}

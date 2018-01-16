using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCheck.Administradores.Modeling
{
    public class Estado
    {
        public string NomeCompleto { get; set; }
        public string NomeAbreviado { get; set; }

        public Estado(string nomeCompleto, string nomeAbreviado)
        {
            this.NomeCompleto = nomeCompleto;
            this.NomeAbreviado = nomeAbreviado;
        }

        public static IList<Estado> ListState()
        {
            return new List<Estado>()
            { 
                new Estado("São Paulo", "SP"),
                new Estado("Bahia", "BA"),
                new Estado("Minas Gerais", "MG"),
                new Estado("Amazonas", "AM"),
                new Estado("Paraná", "PR"),
                new Estado("Santa Catarina", "SC"),
                new Estado("Goiás", "GO"),
                new Estado("Rio Grande do Sul", "RS"),
                new Estado("Rio de Janeiro", "RJ"),
                new Estado("Pará", "PA"),
                new Estado("Pernambuco", "PE"),
                new Estado("Espírito Santo", "ES"),
                new Estado("Distrito Federal", "DF"),
                new Estado("Ceará", "CE"),
                new Estado("Mato Grosso", "MT"),
                new Estado("Maranhão", "MA"),
                new Estado("Mato Grosso do Sul", "MS"),
                new Estado("Paraíba", "PB"),
                new Estado("Sergipe", "SE"),
                new Estado("Tocantins", "TO"),
                new Estado("Alagoas", "AL"),
                new Estado("Rio Grande do Norte", "RN"),
                new Estado("Piauí", "PI"),
                new Estado("Acre", "AC"),
                new Estado("Rondônia", "RO"),
                new Estado("Roraima", "RR"),
                new Estado("Amapá", "AP")
            };
        }

        public override string ToString()
        {
            return this.NomeAbreviado;
        }
    }
}

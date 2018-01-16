using System;
using System.Collections.Generic;

namespace MovieCheck.Administradores.Modeling
{
    public class Telefone
    {
        public int Id { get; set; }
        public int Tipo { get; set; }  //0 = FIXO - 1 = CELULAR
        public int Ddd { get; set; }
        public string Numero { get; set; }
        public IList<UsuarioTelefone> Usuarios { get; set; }

        /********** FUNCTIONS **********/

        public override bool Equals(object telefone)
        {
            Telefone tel = (Telefone)telefone;
            return this.Tipo == tel.Tipo && this.Ddd == tel.Ddd && this.Numero == tel.Numero;
        }

        public static bool IsValidDdd(int ddd)
        {
            var listaDdd = new List<int>() { 11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 24, 27, 28, 31, 31, 32, 33, 34, 35, 37, 38, 41, 42, 43, 44, 45, 46, 47, 48, 49, 51, 53, 54, 55, 61, 62, 23, 64, 65, 66, 67, 68, 69, 71, 73, 74, 75, 77, 79, 81, 82, 83, 84, 85, 86, 87, 88, 89, 91, 92, 93, 94, 95, 96, 97, 98, 99 };
            //11, 12, 13, 14, 15, 16, 17, 18, 19, 21, 22, 24, 27, 28, 31, 31, 32, 33, 34, 35, 37, 38, 41, 42, 43, 44, 45, 46, 47, 48, 49, 51, 53, 54, 55, 61, 62, 23, 64, 65, 66, 67, 68, 69, 71, 73, 74, 75, 77, 79, 81, 82, 83, 84, 85, 86, 87, 88, 89, 91, 92, 93, 94, 95, 96, 97, 98, 99);

            if (ddd.ToString().Length == 2)
            {
                if (listaDdd.Contains(ddd))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
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

    }
}

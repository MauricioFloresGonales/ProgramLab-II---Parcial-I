using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public static class Validaciones
    {
        /// <summary>
        /// Verifica que el string 'cualEs' sea igual que 'cualTieneQueSer'
        /// </summary>
        /// <param name="cualEs">string a validar</param>
        /// <param name="cualTieneQueSer">string que deberia ser</param>
        /// <returns>retorna true si son iguales de lo contrario retorna false</returns>
        public static bool stringIsEqual(string cualEs, string cualTieneQueSer)
        {
            string aux = cualEs.ToLower();
            if (aux.Equals(cualTieneQueSer.ToLower()))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Valida si el numero ingresado en negativo
        /// </summary>
        /// <param name="numero">numero a validar</param>
        /// <returns>TRUE si negativo de lo contrario FALSE</returns>
        public static bool esNegativo(int numero)
        {
            char negativo = '-';
            string aux = numero.ToString();

            for (int i = 0; i < aux.Length; i++)
            {
                if (aux[i] == negativo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

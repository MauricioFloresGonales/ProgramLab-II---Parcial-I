using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Validador
    {
        public static string SacarEspaciosDeMas(string aux)
        {
            string retorno = "";
            char anterior = '.';
            foreach (char c in aux)
            {
                if (anterior == ' ' && c == ' ')
                {
                    return retorno;
                }
                if (c == ' ')
                {
                    if(anterior != ' ')
                        retorno = retorno + c;
                    anterior = c;
                }
                    
                else
                    retorno = retorno + c;
            }
            return retorno;
        }
    }
}

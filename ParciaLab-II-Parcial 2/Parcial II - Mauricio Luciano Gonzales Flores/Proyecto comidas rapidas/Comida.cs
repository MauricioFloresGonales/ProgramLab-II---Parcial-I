using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_comidas_rapidas
{
    class Comida
    {
        int id;
        string nombre;
        int precio;

        public Comida(int id, string nombre, int precio)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}

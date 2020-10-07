using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class Cliente:Persona
    {
        List<Venta> compras;
        bool simpson;
        public bool Simpson
        {
            get { return simpson; }
        }
        public Cliente(string nombre, string apellido) : base(nombre, apellido)
        {
            compras = new List<Venta>();
            this.nombre = nombre;
            this.apellido = apellido;
            this.simpson = Validaciones.stringIsEqual(apellido, "simpson");
        }
        public bool Comprar(Venta producto)
        {
            if (compras != null && producto != null)
            {
                compras.Add(new Venta(
                    producto.Id,
                    producto.Descripcion,
                    producto.Precio,
                    producto.Cantidad,
                    this.Simpson
                    ));
                return true;
            }
            return false;
        }
        public int Devolver(Producto producto)
        {
            int auxCantidad = 0;
            if (compras != null && producto != null)
            {
                foreach (Venta compra in this.compras)
                {
                    if(compra == producto)
                    {
                        auxCantidad = compra.Cantidad;
                        if (compras.Remove(compra))
                            return auxCantidad;
                    }
                }
            }
            return auxCantidad;
        }
    }
}

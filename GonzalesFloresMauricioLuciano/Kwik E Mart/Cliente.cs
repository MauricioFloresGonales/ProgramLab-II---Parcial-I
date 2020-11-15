using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
        public List<Venta> Compras
        {
            get { return compras; }
        }
        public Cliente(string nombre, string apellido) : base(nombre, apellido)
        {
            compras = new List<Venta>();
            this.nombre = nombre;
            this.apellido = apellido;
            this.simpson = Validaciones.stringIsEqual(apellido, "simpson");
        }
        public bool Comprar(int id, string descripcion, float precio, int cantidad)
        {
                compras.Add(new Venta(
                    id,
                    descripcion,
                    precio,
                    cantidad,
                    false
                    ));
                return true;
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
        public string mostrarVentas()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Venta venta in this.Compras)
            {
                sb.AppendLine(venta.ToString());
            }
            return sb.ToString();
        }
        static public Cliente dameUnCliente(List<Cliente> clientes, string nombre)
        {
            foreach (Cliente c in clientes)
            {
                if(Validaciones.stringIsEqual(c.Nombre, nombre))
                {
                    return c;
                }
            }
            return null;
        }
    }
}

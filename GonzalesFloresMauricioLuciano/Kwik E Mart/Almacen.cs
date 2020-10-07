using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class Almacen : Producto
    {
        bool stock;
        public bool Stock
        {
            get { return stock; }
        }
        private bool ValidarStock()
        {
            if (this.Cantidad <= 0)
                return this.stock = false;
            else
                return this.stock = true;
        }
        public Almacen(int id, string descripcion, float precio, int cantidad) : base(id, descripcion, precio, cantidad)
        {
            ValidarStock();
        }
        public override bool RestarProductos(int cantidad)
        {
            base.RestarProductos(cantidad);
            this.ValidarStock();
            return true;
        }
        public override bool SumarProductos(int cantidad)
        {
            base.SumarProductos(cantidad);
            this.ValidarStock();
            return true;
        }
        public static bool operator +(Almacen productoActual, int cantidad)
        {
            int cantidadFinal = Producto.CantidadMinimaValida(cantidad);
            productoActual.Cantidad = productoActual.Cantidad + cantidadFinal;
            productoActual.ValidarStock();
            return true;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(this.stock.ToString());
            return sb.ToString();
        }
    }
}

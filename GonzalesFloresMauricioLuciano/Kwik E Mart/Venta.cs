using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public class Venta: Producto
    {
        bool descuento;
        public bool Descuento
        {
            get { return descuento; }
        }
        public override float PrecioFinal
        {
            get { return base.PrecioFinal; }
            set { base.PrecioFinal = value; }
        }

        public Venta(int id, string descripcion, float precio, int cantidad, bool descuento) : base(id, descripcion, precio, cantidad)
        {
            this.descuento = descuento;
            this.PrecioFinal = tieneDescuento(descuento);
        }
        private float tieneDescuento(bool value)
        {
            float resultado;
            if (value == true)
                resultado = (float)base.PrecioFinal * 25 / 100;
            else
                resultado = base.PrecioFinal;
            return resultado;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString());
            sb.Append(this.descuento.ToString());
            return sb.ToString();
        }
    }
}

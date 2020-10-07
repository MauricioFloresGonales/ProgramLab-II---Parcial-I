using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public abstract class Producto
    {
        int id;
        string descripcion;
        float precio;
        int cantidad;
        float precioFinal;

        public int Id
        {
            get { return id; }
        }
        public string Descripcion
        {
            get { return descripcion; }
        }
        public float Precio
        {
            get { return precio; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set
            {
                if (value < 0)
                    this.cantidad = 0;
                else
                    this.cantidad = value;
            }
        }
        public virtual float PrecioFinal
        {
            get { return precioFinal; }
            set
            {
                if(value > 0)
                this.precioFinal = value;
            }
        }

        /// <summary>
        /// Constructor del producto
        /// </summary>
        /// <param name="descripcion">nombre del producto</param>
        /// <param name="precio">presio del producto</param>
        /// <param name="cantidad">cantidad de productos iguales esta llevando</param>
        /// <param name="precioFinal">precio total del producto </param>
        public Producto(int id, string descripcion, float precio, int cantidad)
        {
            this.id = id;
            this.descripcion = descripcion;
            this.precio = precio;
            this.cantidad = cantidad;
            this.PrecioFinal = cantidad * precio;
        }
        public static bool operator ==(Producto producto, Producto otroProducto)
        {
            if (producto.Id == otroProducto.Id)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Producto producto, Producto otroProducto)
        {
            return !(producto == otroProducto);
        }
        public static int CantidadMinimaValida(int cantidad)
        {
            if (cantidad < 0)
                return 1;
            else
                return cantidad;
        }
        public virtual bool RestarProductos(int valorARestar)
        {
            int cantidad = this.Cantidad - valorARestar;
            if (cantidad < 0)
                this.cantidad = 0;
            else
                this.cantidad = cantidad;
            return true;
        }
        public virtual bool SumarProductos(int valorASumar)
        {
            this.cantidad = this.Cantidad + valorASumar;
            return true;
        }
        public virtual string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(this.id.ToString());
            sb.Append(this.descripcion);
            sb.Append(this.precio.ToString());
            sb.Append(this.cantidad.ToString());
            sb.Append(this.precioFinal.ToString());

            return sb.ToString();
        }
    }
}

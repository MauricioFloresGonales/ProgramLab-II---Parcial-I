using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kwik_E_Mart
{
    public static class Supermercado
    {
        public static bool NuevoProductoAlAlmacen(List<Almacen> listaDelAlmacen, Almacen producto)
        {
             listaDelAlmacen.Add(producto);
             return true;
        }
        public static bool NuevoClientes(List<Cliente> listaClientes, Cliente cliente)
        {
            listaClientes.Add(cliente);
            return true;
        }
        public static bool NuevoEmpleado(List<Empleado> listaEmpleados, Empleado empleado)
        {
            listaEmpleados.Add(empleado);
            return true;
        }
        public static bool VentaDeMisProductos(List<Almacen> listaDelAlmacen, Cliente cliente, Venta producto)
        {
            if(listaDelAlmacen != null && cliente!=null)
            {
                foreach (Almacen venta in listaDelAlmacen)
                {
                    if (venta == producto)
                    {
                        if(cliente.Comprar(producto))
                        return venta.RestarProductos(producto.Cantidad);
                    }
                }
            }
            return false;
        }
        public static bool DevolucionDeLaVenta(List<Almacen> listaDelAlmacen, Cliente cliente, Venta producto)
        {
            if (listaDelAlmacen != null)
            {
                foreach (Almacen almacen in listaDelAlmacen)
                {
                    if (almacen == producto)
                    {
                        return almacen + cliente.Devolver(producto);
                    }
                }
            }
            return false;
        }
        public static bool AgregarProducto(List<Almacen> listaDelAlmacen, Almacen nuevoProducto)
        {
            if (listaDelAlmacen != null)
            {
                foreach (Almacen almacen in listaDelAlmacen)
                {
                    if (Validaciones.stringIsEqual(almacen.Descripcion, nuevoProducto.Descripcion))
                    {
                        almacen.SumarProductos(nuevoProducto.Cantidad);
                        return true;
                    }
                }
                return NuevoProductoAlAlmacen(listaDelAlmacen, nuevoProducto);
            }
            return false;
        }
        public static bool SacarProducto(List<Almacen> listaDelAlmacen, Almacen producto)
        {
            if (listaDelAlmacen != null)
            {
                foreach (Almacen almacen in listaDelAlmacen)
                {
                    if (almacen == producto)
                    {
                        almacen.RestarProductos(producto.Cantidad);
                        return true;
                    }
                }
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Kwik_E_Mart
{
    public static class Supermercado
    {
        public static List<Empleado> empleados;
        public static List<Cliente> clientes;
        public static List<Inventario> almacen;

        static Supermercado()
        {
           empleados = new List<Empleado>();
           clientes = new List<Cliente>();
           almacen = new List<Inventario>();
        }
        public static void cargarInventario()
        {
            Cliente clienteUno = new Cliente("Homero", "Simpson");
            Cliente clienteDos = new Cliente("mauricio", "Gonzales");

            Inventario inventarioUno = new Inventario(1, "Cereales Krusty", 2, 4);
            Inventario inventarioDos = new Inventario(2, "BuzzCola,", 4, 8);
            Inventario inventarioTres = new Inventario(3, "CervezaDuff", 6, 12);
            Inventario inventarioCuatro = new Inventario(4, "Squishees,", 8, 16);
            Inventario inventarioCinco  = new Inventario(5, "Radioctive Man Comics,", 10, 20);
            Inventario inventarioSeis  = new Inventario(6, "Rosquillas,", 12, 24);
            Inventario inventarioSiete  = new Inventario(7, "Armas,", 14, 28);
            Inventario inventarioOcho  = new Inventario(8, "Raspados Fresisuis,", 16, 28);
            Inventario inventarioNueve = new Inventario(9, "Boletos de Lotería,,", 18, 20);
            Inventario inventarioDiez = new Inventario(10, "LecheDe1961,", 20, 4);

            Supermercado.NuevoProductoAlAlmacen(almacen, inventarioUno);
            Supermercado.NuevoProductoAlAlmacen(almacen, inventarioDos);
            Supermercado.NuevoProductoAlAlmacen(almacen, inventarioTres);
            Supermercado.NuevoProductoAlAlmacen(almacen, inventarioCuatro);
            Supermercado.NuevoProductoAlAlmacen(almacen, inventarioCinco);
            Supermercado.NuevoProductoAlAlmacen(almacen, inventarioSeis);
            Supermercado.NuevoProductoAlAlmacen(almacen, inventarioSiete);
            Supermercado.NuevoProductoAlAlmacen(almacen, inventarioOcho);
            Supermercado.NuevoProductoAlAlmacen(almacen, inventarioNueve);
            Supermercado.NuevoProductoAlAlmacen(almacen, inventarioDiez);

            Supermercado.NuevoClientes(clientes, clienteUno);
            Supermercado.NuevoClientes(clientes, clienteDos);

            Supermercado.VentaDeMisProductos(almacen, clienteUno, 1,2);
            Supermercado.VentaDeMisProductos(almacen, clienteUno,5, 10);
        }
        public static void cargarEmpleados()
        {
            Supermercado.NuevoEmpleado(empleados, new Empleado("Apu", "Nahasapeemapetilon", 24, 0, Empleado.EUsuarios.Apu));
            Supermercado.NuevoEmpleado(empleados, new Empleado("mauricio", "Gonzales", 0, 0, Empleado.EUsuarios.mauricio));
        }
        public static bool NuevoProductoAlAlmacen(List<Inventario> listaDelAlmacen, Inventario producto)
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
        public static bool VentaDeMisProductos(List<Inventario> listaDelAlmacen, Cliente cliente, int id, int cantidad)
        {
            if(listaDelAlmacen != null && cliente!=null)
            {
                foreach (Inventario inv in listaDelAlmacen)
                {
                    if (inv.Id == id)
                    {
                        if(cantidad>inv.Cantidad)
                        {
                            if (cliente.Comprar(inv.Id, inv.Descripcion, inv.Precio, inv.Cantidad))
                                return inv.RestarProductos(inv.Cantidad);
                        }
                        else
                        {
                            if (cliente.Comprar(inv.Id, inv.Descripcion, inv.Precio, cantidad))
                                return inv.RestarProductos(cantidad);
                        }
                    }
                }
            }
            return false;
        }
        public static bool DevolucionDeLaVenta(List<Inventario> listaDelAlmacen, Cliente cliente, int id, int cantidad)
        {
            bool retorno = false;
            if (listaDelAlmacen != null)
            {
                foreach (Inventario almacen in listaDelAlmacen)
                {
                    if (almacen.Id == id)
                    {
                        retorno = almacen + cantidad;
                        break;
                    }
                }
                retorno = DevolucionDeCompra(cliente, id, cantidad);
            }
            return retorno;
        }
        public static bool DevolucionDeCompra(Cliente cliente, int id, int cantidad)
        {
            Venta auxVenta = null;
            bool validador = false;
            bool retorno = false;
            if (cliente != null)
            {
                foreach (Venta v in cliente.Compras)
                {
                    if (v.Id == id)
                    {
                        v.RestarProductos(cantidad);
                        if(v.Cantidad < 0)
                        {
                            auxVenta = v;
                            validador = true;
                        }
                        break;
                    }
                }
                if(validador != false)
                    cliente.Compras.Remove(auxVenta);
            }
            return retorno;
        }

        public static bool AgregarProducto(List<Inventario> listaDelAlmacen, Inventario nuevoProducto)
        {
            if (listaDelAlmacen != null)
            {
                foreach (Inventario almacen in listaDelAlmacen)
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
        public static bool SacarProducto(List<Inventario> listaDelAlmacen, int id, int cantidad)
        {
            if (listaDelAlmacen != null)
            {
                foreach (Inventario almacen in listaDelAlmacen)
                {
                    if (almacen.Id == id)
                    {
                        almacen.RestarProductos(cantidad);
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool ValidarContraseña(List<Empleado> empleados,string usuario, string contrasenia)
        {
            bool retorno = false;
            try
            {
                foreach (Empleado e in empleados)
                {
                    if(e == usuario)
                    {
                        retorno = e.contrasenias(e.Usuario, contrasenia);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return retorno;
        }
        public static List<Venta> mostrarVentasDeUnCliente(List<Cliente> clientes, Cliente unCliente)
        {
            foreach (Cliente c in clientes)
            {
                if(Validaciones.stringIsEqual(c.Nombre,unCliente.Nombre))
                {
                    return c.Compras;
                }
            }
            return null;
        }
        public static float SumaAPagar(List<Cliente> clientes, Cliente unCliente)
        {
            float final = 0;
            foreach (Cliente c in clientes)
            {
                if (Validaciones.stringIsEqual(c.Nombre, unCliente.Nombre))
                {
                    foreach (Venta v in c.Compras)
                    {
                        final = final + v.PrecioFinal;
                    }
                }
            }
            return final;
        }
        public static void mostrarTicket(List<Venta> ventas, string fileName)
        {
            Archivos.CrearArchivoTxt(ventas, fileName);
        }
    }
}

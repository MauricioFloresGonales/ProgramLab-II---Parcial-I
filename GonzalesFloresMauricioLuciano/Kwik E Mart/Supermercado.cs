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

            Supermercado.VentaDeMisProductos(almacen, clienteUno, new Venta(1, "Cereales Krusty",2,1,true));
            Supermercado.VentaDeMisProductos(almacen, clienteUno, new Venta(5, "Radioctive Man Comics,", 10, 1,true));
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
        public static bool VentaDeMisProductos(List<Inventario> listaDelAlmacen, Cliente cliente, Venta producto)
        {
            if(listaDelAlmacen != null && cliente!=null)
            {
                foreach (Inventario venta in listaDelAlmacen)
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
        public static bool DevolucionDeLaVenta(List<Inventario> listaDelAlmacen, Cliente cliente, Venta producto)
        {
            if (listaDelAlmacen != null)
            {
                foreach (Inventario almacen in listaDelAlmacen)
                {
                    if (almacen == producto)
                    {
                        return almacen + cliente.Devolver(producto);
                    }
                }
            }
            return false;
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
        public static bool SacarProducto(List<Inventario> listaDelAlmacen, Inventario producto)
        {
            if (listaDelAlmacen != null)
            {
                foreach (Inventario almacen in listaDelAlmacen)
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
        public static string mostrarVentasDeUnCliente(List<Cliente> clientes, Cliente unCliente)
        {
            foreach (Cliente c in clientes)
            {
                if(Validaciones.stringIsEqual(c.Nombre,unCliente.Nombre))
                {
                    return c.mostrarVentas();
                }
            }
            return "";
        }
    }
}

using Kwik_E_Mart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kwik_E_Mart_App
{
    public partial class FrmPrincipal : Form
    {
        public static List<Empleado> empleados;
        public static List<Cliente> clientes;
        public static List<Almacen> almacen;
        public FrmPrincipal()
        {
            InitializeComponent();
            empleados = new List<Empleado>();
            clientes = new List<Cliente>();
            almacen = new List<Almacen>();
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            Supermercado.NuevoProductoAlAlmacen(almacen,new Almacen(1, "Cereales Krusty", 2, 4));
            Supermercado.NuevoProductoAlAlmacen(almacen, new Almacen(2, "BuzzCola,", 4, 8));
            Supermercado.NuevoProductoAlAlmacen(almacen, new Almacen(3, "CervezaDuff", 6, 12));
            Supermercado.NuevoProductoAlAlmacen(almacen, new Almacen(4, "Squishees,", 8, 16));
            Supermercado.NuevoProductoAlAlmacen(almacen, new Almacen(5, "Radioctive Man Comics,", 10, 20));
            Supermercado.NuevoProductoAlAlmacen(almacen, new Almacen(6, "Rosquillas,", 12, 24));
            Supermercado.NuevoProductoAlAlmacen(almacen, new Almacen(7, "Armas,", 14, 28));
            Supermercado.NuevoProductoAlAlmacen(almacen, new Almacen(8, "Raspados Fresisuis,", 16, 28));
            Supermercado.NuevoProductoAlAlmacen(almacen, new Almacen(8, "Boletos de Lotería,,", 18, 20));
            Supermercado.NuevoProductoAlAlmacen(almacen, new Almacen(9, "LecheDe1961,", 20, 4));
            Supermercado.NuevoClientes(clientes, new Cliente("Homero", "Simpson"));
            Supermercado.NuevoClientes(clientes, new Cliente("mauricio", "Gonzales"));
            Supermercado.NuevoEmpleado(empleados, new Empleado("Apu", "Nahasapeemapetilon", 24, 0));
            Supermercado.NuevoEmpleado(empleados, new Empleado("mauricio", "Gonzales", 0, 0)); 
        }

        private void btnAdministrar_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            if(frmLogin.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            FrmCompras frmCompras = new FrmCompras();
            if (frmCompras.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}

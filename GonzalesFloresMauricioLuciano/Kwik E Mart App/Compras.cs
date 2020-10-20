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
    public partial class FrmCompras : Form
    {
        int id;
        int cantidad;
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmCompras_Load(object sender, EventArgs e)
        {
            dgvAlmacen.DataSource = Supermercado.almacen;
            dtgvCompras.DataSource = Supermercado.mostrarVentasDeUnCliente(Supermercado.clientes, Cliente.dameUnCliente(Supermercado.clientes, "homero"));
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            //Supermercado.VentaDeMisProductos(Supermercado.almacen, Supermercado.NuevoClientes(Supermercado.clientes, new Cliente("mauricio", "Gonzales")),new Venta(this.id,"",0,this.cantidad, false));
        }

        private void txtIdCompra_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(this.txtIdCompra.Text, out id);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(this.txtCantidad.Text, out id);
        }
    }
}

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
        public FrmCompras()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            

            DialogResult result = MessageBox.Show("Deseas un ticket de tus compras?", "ticket?", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Supermercado.mostrarTicket(Supermercado.clientes.ElementAt(0).Compras, "Ticket.txt");
                this.DialogResult = DialogResult.OK;
            }
            else if (result == DialogResult.No)
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private void actualizarData()
        {
            this.dgvAlmacen.DataSource = null;
            this.dgvAlmacen.DataSource = Supermercado.almacen;
            this.dtgvCompras.DataSource = null;
            this.dtgvCompras.DataSource = Supermercado.mostrarVentasDeUnCliente(Supermercado.clientes, Cliente.dameUnCliente(Supermercado.clientes, "homero"));
            this.lblAPagar.Text = "Precio final : " + Supermercado.SumaAPagar(Supermercado.clientes, Supermercado.clientes.ElementAt(0)).ToString();
        }
        private void FrmCompras_Load(object sender, EventArgs e)
        {
            this.actualizarData();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            FrmAgregarCompra frmAgregarCompra = new FrmAgregarCompra();
            if (frmAgregarCompra.ShowDialog() == DialogResult.OK)
            {
                this.actualizarData();
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            RetirarCompra retirarCompra = new RetirarCompra();
            if (retirarCompra.ShowDialog() == DialogResult.OK)
            {
                this.actualizarData();
            }
        }
    }
}

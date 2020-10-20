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
    public partial class FrmAdministracion : Form
    {
        int id;
        string descripcion;
        float precio;
        int cantidad;
 
        public FrmAdministracion()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void FrmAdministracion_Load(object sender, EventArgs e)
        {
           dgvAlmacen.DataSource = Supermercado.almacen;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Supermercado.NuevoProductoAlAlmacen(Supermercado.almacen, new Inventario(this.id, this.descripcion, this.precio, this.cantidad));
            
            /*
            int index = dgvAlmacen.Rows.Add();
            dgvAlmacen.Rows[index].Cells[0].Value = id.ToString();
            dgvAlmacen.Rows[index].Cells[1].Value = cantidad;
            dgvAlmacen.Rows[index].Cells[2].Value = precio.ToString();
            dgvAlmacen.Rows[index].Cells[3].Value = cantidad.ToString() ;
            txtId.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";*/
        }
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            Supermercado.SacarProducto(Supermercado.almacen, new Inventario(this.id, this.descripcion, this.precio, this.cantidad)) ;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(this.txtId.Text, out this.id);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            this.descripcion = this.txtDescripcion.Text;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            float.TryParse(this.txtPrecio.Text, out this.precio);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(this.txtCantidad.Text, out this.cantidad);
        }
    }
}

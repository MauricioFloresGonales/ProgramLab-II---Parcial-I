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
    public partial class FrmAgregarCompra : Form
    {

        int id;
        int cantidad;
        
        public int Id
        {
            get { return id; }
        }
        public int Cantidad
        {
            get { return cantidad; }
        }
        public FrmAgregarCompra()
        {
            InitializeComponent();
        }
        
        public virtual void aceptar()
        {
            try
            {
                Supermercado.VentaDeMisProductos(Supermercado.almacen, Supermercado.clientes.ElementAt(0), this.id, this.cantidad);
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Error al ingresar el item"); ;
            }
            finally
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            aceptar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(this.txtId.Text, out id);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            int.TryParse(this.txtCantidad.Text, out cantidad);
        }
    }
}

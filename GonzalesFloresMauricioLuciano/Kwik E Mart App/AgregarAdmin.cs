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
    public partial class frmAgregarAdmin : Form
    {
        public frmAgregarAdmin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Supermercado.AgregarProducto(Supermercado.almacen,
                    new Inventario(int.Parse(this.txtId.Text), this.txtDescripcion.Text, 
                    float.Parse(this.txtPrecio.Text), int.Parse(this.txtCantidad.Text)));
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message, "Error al retirar el item"); ;
            }
            finally
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}

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
    public partial class RetirarCompra : FrmAgregarCompra
    {
        public override void aceptar()
        {
            try
            {
                Supermercado.DevolucionDeLaVenta(Supermercado.almacen, Supermercado.clientes.ElementAt(0), this.Id, this.Cantidad);
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

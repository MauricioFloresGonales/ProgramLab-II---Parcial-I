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
        public FrmPrincipal()
        {
            InitializeComponent();
            Supermercado.cargarInventario();
            Supermercado.cargarEmpleados();

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

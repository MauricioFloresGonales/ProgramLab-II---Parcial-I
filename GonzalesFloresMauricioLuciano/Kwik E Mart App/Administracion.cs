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
        public FrmAdministracion()
        {
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void actualizarData()
        {
            this.dgvAlmacen.DataSource = null;
            this.dgvAlmacen.DataSource = Supermercado.almacen;
        }
        private void FrmAdministracion_Load(object sender, EventArgs e)
        {
            this.actualizarData();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarAdmin frmAgregarAdmin = new frmAgregarAdmin();
            if (frmAgregarAdmin.ShowDialog() == DialogResult.OK)
            {
                this.actualizarData();
            }
        }
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            frmRetirarAdmin frmRetirarAdmin = new frmRetirarAdmin();
            if (frmRetirarAdmin.ShowDialog() == DialogResult.OK)
            {
                this.actualizarData();
            }
        }
    }
}

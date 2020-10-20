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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Supermercado.ValidarContraseña(Supermercado.empleados, txtUsuario.Text, txtContraseña.Text))
                {
                    FrmAdministracion frmAdmin = new FrmAdministracion();
                    if (frmAdmin.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("mensaje", "titulo");
            }
            
            
        }
    }
}

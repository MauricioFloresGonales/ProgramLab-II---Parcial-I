using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Proyecto_comidas_rapidas;

namespace App_Comidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Carta.Iniciar();
        }
    }
}

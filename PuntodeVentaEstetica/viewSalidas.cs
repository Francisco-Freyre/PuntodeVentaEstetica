using PuntodeVentaEstetica.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVentaEstetica
{
    public partial class viewSalidas : Form
    {
        private Ingreso ingreso = new Ingreso();
        public viewSalidas()
        {
            InitializeComponent();
        }

        private void btnAcep_Click(object sender, EventArgs e)
        {
            ingreso.insetarSalida(txtMonto.Text, txtSalida.Text);
            txtMonto.Text = "";
            txtSalida.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

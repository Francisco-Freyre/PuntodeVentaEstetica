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
    public partial class viewEntradas : Form
    {
        private Ingreso ingreso = new Ingreso();
        public viewEntradas()
        {
            InitializeComponent();
        }

        private void btnAcep_Click(object sender, EventArgs e)
        {
            ingreso.insetarEntrada(txtMonto.Text, txtSalida.Text);
            txtMonto.Text = "";
            txtSalida.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

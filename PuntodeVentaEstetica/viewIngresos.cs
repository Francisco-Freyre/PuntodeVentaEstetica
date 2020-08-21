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
    public partial class viewIngresos : Form
    {
        private Ingreso ingreso = new Ingreso();
        public viewIngresos()
        {
            InitializeComponent();
        }

        private void btnAcep_Click(object sender, EventArgs e)
        {
            ingreso.insetarIngresoInicial(textBox1.Text);
            this.Close();
        }
    }
}

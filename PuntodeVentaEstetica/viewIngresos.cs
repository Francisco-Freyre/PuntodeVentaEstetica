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
            textBox1.Focus();
            textBox1.Text = "$0.00";
        }

        private void btnAcep_Click(object sender, EventArgs e)
        {
            ingreso.insetarIngresoInicial(textBox1.Text);
            Form1 formulario = new Form1();
            formulario.Show();
            this.Hide();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                ingreso.insetarIngresoInicial(textBox1.Text);
                Form1 formulario = new Form1();
                formulario.Show();
                this.Hide();
            }
        }
    }
}

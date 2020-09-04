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
    public partial class viewCorte : Form
    {
        private Corte corte = new Corte();
        public viewCorte()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            corte.cortesGlobales(lblInicio, lblSalida, lblEntrada, lblEfectivo, lblTarjeta, lblTotal, dateTimePicker1);
        }
    }
}

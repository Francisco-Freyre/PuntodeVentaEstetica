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
        private Imprimir imprimir = new Imprimir();

        private GroupBox gb;
        private DateTimePicker dtp;
        private string tipo, usuario, pago, cambio;
        public viewCorte()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            imprimir.printDocument(e, gb, tipo, dateTimePicker1, usuario, pago, cambio, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            corte.cortesGlobales(lblInicio, lblSalida, lblEntrada, lblEfectivo, lblTarjeta, lblTotal, lblServicio,  lblProducto, dateTimePicker1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gb = null;
            pago = "";
            cambio = "";
            tipo = "cortediario";
            printDocument1.Print();
        }
    }
}

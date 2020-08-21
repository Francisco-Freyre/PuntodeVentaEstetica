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
    
    public partial class collect : Form
    {
        private int Numeroventa, idCliente = -1;
        private Cliente cliente = new Cliente();
        private Ventas ventas = new Ventas();
        public collect(Label total, int venta)
        {
            InitializeComponent();
            this.lblTotal = total;
            this.Numeroventa = venta;
            containerClient.Visible = false;
            cliente.buscarClienteDos(dgvClient, "");
            txtPago.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxHistorial_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHistorial.Checked)
            {
                containerClient.Visible = true;
            }
            else
            {
                containerClient.Visible = false;
            }
        }

        private void btnCobrarImp_Click(object sender, EventArgs e)
        {
            ventas.cobrar(cbxHistorial, cbxTarjeta, txtPago, lblCambio, Numeroventa, idCliente);
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = Convert.ToInt16(dgvClient.CurrentRow.Cells[0].Value);
        }
    }
}

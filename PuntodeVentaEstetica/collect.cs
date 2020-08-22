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
        private bool valor;
        DataGridView dgv1;
        public collect(Label total, int venta, DataGridView dgv1)
        {
            InitializeComponent();
            this.dgv1 = dgv1;
            this.lblTotal = total;
            this.lblTotal.Text = total.Text;
            this.Numeroventa = venta;
            containerClient.Visible = false;
            cliente.buscarClienteDos(dgvClient, "");
            txtPago.Focus();
        }

        public void restablecer()
        {
            ventas.buscarVentaTempo(dgv1, Numeroventa);
            ventas.importes(lblTotal, Numeroventa);
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
            if (valor)
            {
                ventas.cobrar(cbxHistorial, cbxTarjeta, txtPago, lblCambio, Numeroventa, idCliente);
            }
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
           valor = ventas.pagosCliente(txtPago, label5, lblCambio, label4, lblTotal);
        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = Convert.ToInt16(dgvClient.CurrentRow.Cells[0].Value);
        }
    }
}

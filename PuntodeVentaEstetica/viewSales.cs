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
    public partial class viewSales : Form
    {
        private Ventas venta = new Ventas();
        private Cliente cliente = new Cliente();
        private Imprimir imprimir = new Imprimir();
        private bool valor;
        private int idCliente = -1;
        private GroupBox gb;
        private DateTimePicker dtp;
        private string tipo = "venta", usuario, pago, cambio;
        public viewSales()
        {
            InitializeComponent();
            venta.buscarVentaTempo(dgv, 0);
            venta.importes(lblTotal, 0);
            tabControl1.TabPages.Remove(tabPage2);
            tabControl1.TabPages.Remove(tabPage3);
            tabControl1.TabPages.Remove(tabPage4);
            tabControl1.TabPages.Remove(tabPage5);
            tabControl1.TabPages.Remove(tabPage6);
            tabControl1.TabPages.Remove(tabPage7);
            tabControl1.TabPages.Remove(tabPage8);
            tabControl1.TabPages.Remove(tabPage9);
            tabControl1.TabPages.Remove(tabPage10);
            cliente.buscarClienteDos(dgvClient, "");
            panel2.Visible = false;
            txtCodigo.Focus();

        }

        private void txtCodigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo.Text == "")
                {
                    label_MensajeVenta.Text = "Ingrese un codigo de barras";
                    label_MensajeVenta.ForeColor = Color.Red;
                }
                else
                {
                    var producto = venta.buscarProductos(txtCodigo.Text);
                    if (producto.Count > 0)
                    {
                        if (producto[0].existencia.Equals(0))
                        {
                            label_MensajeVenta.Text = "No hay productos en existencia";
                            label_MensajeVenta.ForeColor = Color.Red;
                        }
                        else
                        {
                            label_MensajeVenta.Text = "";
                            venta.guardarVentasTempo(txtCodigo.Text, 0, tabControl1.SelectedIndex);
                            venta.buscarVentaTempo(dgv, tabControl1.SelectedIndex);
                            venta.importes(lblTotal, tabControl1.SelectedIndex);
                        }

                    }
                    else
                    {
                        label_MensajeVenta.Text = "No existe este producto ";
                        label_MensajeVenta.ForeColor = Color.Red;
                    }
                }
                txtCodigo.Text = "";
                txtCodigo.Focus();
            }
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            if (!tabControl1.Controls.Contains(tabPage2))
            {
                tabControl1.TabPages.Add(tabPage2);
                venta.buscarVentaTempo(dgv2, 1);
                venta.importes(lblTotal2, 1);
            }
            else if (!tabControl1.Controls.Contains(tabPage3))
            {
                tabControl1.TabPages.Add(tabPage3);
                venta.buscarVentaTempo(dgv3, 2);
                venta.importes(lblTotal3, 2);
            }
            else if (!tabControl1.Controls.Contains(tabPage4))
            {
                tabControl1.TabPages.Add(tabPage4);
                venta.buscarVentaTempo(dgv4, 3);
                venta.importes(lblTotal4, 3);
            }
            else if (!tabControl1.Controls.Contains(tabPage5))
            {
                tabControl1.TabPages.Add(tabPage5);
                venta.buscarVentaTempo(dgv5, 4);
                venta.importes(lblTotal5, 4);
            }
            else if (!tabControl1.Controls.Contains(tabPage6))
            {
                tabControl1.TabPages.Add(tabPage6);
                venta.buscarVentaTempo(dgv6, 5);
                venta.importes(lblTotal6, 5);
            }
            else if (!tabControl1.Controls.Contains(tabPage7))
            {
                tabControl1.TabPages.Add(tabPage7);
                venta.buscarVentaTempo(dgv7, 6);
                venta.importes(lblTotal7, 6);
            }
            else if (!tabControl1.Controls.Contains(tabPage8))
            {
                tabControl1.TabPages.Add(tabPage8);
                venta.buscarVentaTempo(dgv8, 7);
                venta.importes(lblTotal8, 7);
            }
            else if (!tabControl1.Controls.Contains(tabPage9))
            {
                tabControl1.TabPages.Add(tabPage9);
                venta.buscarVentaTempo(dgv9, 8);
                venta.importes(lblTotal9, 8);
            }
            else if (!tabControl1.Controls.Contains(tabPage10))
            {
                tabControl1.TabPages.Add(tabPage10);
                venta.buscarVentaTempo(dgv10, 9);
                venta.importes(lblTotal10, 9);
            }
        }

        private void btnBorrarVenta_Click(object sender, EventArgs e)
        {
            if (tabControl1.Controls.Contains(tabPage10))
            {
                tabControl1.TabPages.Remove(tabPage10);
            }
            else if (tabControl1.Controls.Contains(tabPage9))
            {
                tabControl1.TabPages.Remove(tabPage9);
            }
            else if (tabControl1.Controls.Contains(tabPage8))
            {
                tabControl1.TabPages.Remove(tabPage8);
            }
            else if (tabControl1.Controls.Contains(tabPage7))
            {
                tabControl1.TabPages.Remove(tabPage7);
            }
            else if (tabControl1.Controls.Contains(tabPage6))
            {
                tabControl1.TabPages.Remove(tabPage6);
            }
            else if (tabControl1.Controls.Contains(tabPage5))
            {
                tabControl1.TabPages.Remove(tabPage5);
            }
            else if (tabControl1.Controls.Contains(tabPage4))
            {
                tabControl1.TabPages.Remove(tabPage4);
            }
            else if (tabControl1.Controls.Contains(tabPage3))
            {
                tabControl1.TabPages.Remove(tabPage3);
            }
            else if (tabControl1.Controls.Contains(tabPage2))
            {
                tabControl1.TabPages.Remove(tabPage2);
            }
        }

        private void txtVenta2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtVenta2.Text == "")
                {
                    label_MensajeVenta.Text = "Ingrese un codigo de barras";
                    label_MensajeVenta.ForeColor = Color.Red;
                }
                else
                {
                    var producto = venta.buscarProductos(txtVenta2.Text);
                    if (producto.Count > 0)
                    {
                        if (producto[0].existencia.Equals(0))
                        {
                            label_MensajeVenta.Text = "No hay productos en existencia";
                            label_MensajeVenta.ForeColor = Color.Red;
                        }
                        else
                        {
                            label_MensajeVenta.Text = "";
                            venta.guardarVentasTempo(txtVenta2.Text, 0, tabControl1.SelectedIndex);
                            venta.buscarVentaTempo(dgv2, tabControl1.SelectedIndex);
                            venta.importes(lblTotal2, tabControl1.SelectedIndex);
                        }

                    }
                    else
                    {
                        label_MensajeVenta.Text = "No existe este producto ";
                        label_MensajeVenta.ForeColor = Color.Red;
                    }
                }
                txtVenta2.Text = "";
                txtVenta2.Focus();
            }
        }

        private void txtCodigo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo3.Text == "")
                {
                    label_MensajeVenta.Text = "Ingrese un codigo de barras";
                    label_MensajeVenta.ForeColor = Color.Red;
                }
                else
                {
                    var producto = venta.buscarProductos(txtCodigo3.Text);
                    if (producto.Count > 0)
                    {
                        if (producto[0].existencia.Equals(0))
                        {
                            label_MensajeVenta.Text = "No hay productos en existencia";
                            label_MensajeVenta.ForeColor = Color.Red;
                        }
                        else
                        {
                            label_MensajeVenta.Text = "";
                            venta.guardarVentasTempo(txtCodigo3.Text, 0, tabControl1.SelectedIndex);
                            venta.buscarVentaTempo(dgv3, tabControl1.SelectedIndex);
                            venta.importes(lblTotal3, tabControl1.SelectedIndex);
                        }

                    }
                    else
                    {
                        label_MensajeVenta.Text = "No existe este producto ";
                        label_MensajeVenta.ForeColor = Color.Red;
                    }
                }
                txtCodigo3.Text = "";
                txtCodigo3.Focus();
            }
        }

        private void txtCodigo4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo4.Text == "")
                {
                    label_MensajeVenta.Text = "Ingrese un codigo de barras";
                    label_MensajeVenta.ForeColor = Color.Red;
                }
                else
                {
                    var producto = venta.buscarProductos(txtCodigo4.Text);
                    if (producto.Count > 0)
                    {
                        if (producto[0].existencia.Equals(0))
                        {
                            label_MensajeVenta.Text = "No hay productos en existencia";
                            label_MensajeVenta.ForeColor = Color.Red;
                        }
                        else
                        {
                            label_MensajeVenta.Text = "";
                            venta.guardarVentasTempo(txtCodigo4.Text, 0, tabControl1.SelectedIndex);
                            venta.buscarVentaTempo(dgv4, tabControl1.SelectedIndex);
                            venta.importes(lblTotal4, tabControl1.SelectedIndex);
                        }

                    }
                    else
                    {
                        label_MensajeVenta.Text = "No existe este producto ";
                        label_MensajeVenta.ForeColor = Color.Red;
                    }
                }
                txtCodigo4.Text = "";
                txtCodigo4.Focus();
            }
        }

        private void txtCodigo5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo5.Text == "")
                {
                    label_MensajeVenta.Text = "Ingrese un codigo de barras";
                    label_MensajeVenta.ForeColor = Color.Red;
                }
                else
                {
                    var producto = venta.buscarProductos(txtCodigo5.Text);
                    if (producto.Count > 0)
                    {
                        if (producto[0].existencia.Equals(0))
                        {
                            label_MensajeVenta.Text = "No hay productos en existencia";
                            label_MensajeVenta.ForeColor = Color.Red;
                        }
                        else
                        {
                            label_MensajeVenta.Text = "";
                            venta.guardarVentasTempo(txtCodigo5.Text, 0, tabControl1.SelectedIndex);
                            venta.buscarVentaTempo(dgv5, tabControl1.SelectedIndex);
                            venta.importes(lblTotal5, tabControl1.SelectedIndex);
                        }

                    }
                    else
                    {
                        label_MensajeVenta.Text = "No existe este producto ";
                        label_MensajeVenta.ForeColor = Color.Red;
                    }
                }
                txtCodigo5.Text = "";
                txtCodigo5.Focus();
            }
        }

        private void txtCodigo6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo6.Text == "")
                {
                    label_MensajeVenta.Text = "Ingrese un codigo de barras";
                    label_MensajeVenta.ForeColor = Color.Red;
                }
                else
                {
                    var producto = venta.buscarProductos(txtCodigo6.Text);
                    if (producto.Count > 0)
                    {
                        if (producto[0].existencia.Equals(0))
                        {
                            label_MensajeVenta.Text = "No hay productos en existencia";
                            label_MensajeVenta.ForeColor = Color.Red;
                        }
                        else
                        {
                            label_MensajeVenta.Text = "";
                            venta.guardarVentasTempo(txtCodigo6.Text, 0, tabControl1.SelectedIndex);
                            venta.buscarVentaTempo(dgv6, tabControl1.SelectedIndex);
                            venta.importes(lblTotal6, tabControl1.SelectedIndex);
                        }

                    }
                    else
                    {
                        label_MensajeVenta.Text = "No existe este producto ";
                        label_MensajeVenta.ForeColor = Color.Red;
                    }
                }
                txtCodigo6.Text = "";
                txtCodigo6.Focus();
            }
        }

        private void txtCodigo7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo7.Text == "")
                {
                    label_MensajeVenta.Text = "Ingrese un codigo de barras";
                    label_MensajeVenta.ForeColor = Color.Red;
                }
                else
                {
                    var producto = venta.buscarProductos(txtCodigo7.Text);
                    if (producto.Count > 0)
                    {
                        if (producto[0].existencia.Equals(0))
                        {
                            label_MensajeVenta.Text = "No hay productos en existencia";
                            label_MensajeVenta.ForeColor = Color.Red;
                        }
                        else
                        {
                            label_MensajeVenta.Text = "";
                            venta.guardarVentasTempo(txtCodigo7.Text, 0, tabControl1.SelectedIndex);
                            venta.buscarVentaTempo(dgv7, tabControl1.SelectedIndex);
                            venta.importes(lblTotal7, tabControl1.SelectedIndex);
                        }

                    }
                    else
                    {
                        label_MensajeVenta.Text = "No existe este producto ";
                        label_MensajeVenta.ForeColor = Color.Red;
                    }
                }
                txtCodigo7.Text = "";
                txtCodigo7.Focus();
            }
        }

        private void txtCodigo8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo8.Text == "")
                {
                    label_MensajeVenta.Text = "Ingrese un codigo de barras";
                    label_MensajeVenta.ForeColor = Color.Red;
                }
                else
                {
                    var producto = venta.buscarProductos(txtCodigo3.Text);
                    if (producto.Count > 0)
                    {
                        if (producto[0].existencia.Equals(0))
                        {
                            label_MensajeVenta.Text = "No hay productos en existencia";
                            label_MensajeVenta.ForeColor = Color.Red;
                        }
                        else
                        {
                            label_MensajeVenta.Text = "";
                            venta.guardarVentasTempo(txtCodigo8.Text, 0, tabControl1.SelectedIndex);
                            venta.buscarVentaTempo(dgv8, tabControl1.SelectedIndex);
                            venta.importes(lblTotal8, tabControl1.SelectedIndex);
                        }

                    }
                    else
                    {
                        label_MensajeVenta.Text = "No existe este producto ";
                        label_MensajeVenta.ForeColor = Color.Red;
                    }
                }
                txtCodigo8.Text = "";
                txtCodigo8.Focus();
            }
        }

        private void txtCodigo9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo9.Text == "")
                {
                    label_MensajeVenta.Text = "Ingrese un codigo de barras";
                    label_MensajeVenta.ForeColor = Color.Red;
                }
                else
                {
                    var producto = venta.buscarProductos(txtCodigo3.Text);
                    if (producto.Count > 0)
                    {
                        if (producto[0].existencia.Equals(0))
                        {
                            label_MensajeVenta.Text = "No hay productos en existencia";
                            label_MensajeVenta.ForeColor = Color.Red;
                        }
                        else
                        {
                            label_MensajeVenta.Text = "";
                            venta.guardarVentasTempo(txtCodigo9.Text, 0, tabControl1.SelectedIndex);
                            venta.buscarVentaTempo(dgv9, tabControl1.SelectedIndex);
                            venta.importes(lblTotal9, tabControl1.SelectedIndex);
                        }

                    }
                    else
                    {
                        label_MensajeVenta.Text = "No existe este producto ";
                        label_MensajeVenta.ForeColor = Color.Red;
                    }
                }
                txtCodigo9.Text = "";
                txtCodigo9.Focus();
            }
        }

        private void txtCodigo10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (txtCodigo10.Text == "")
                {
                    label_MensajeVenta.Text = "Ingrese un codigo de barras";
                    label_MensajeVenta.ForeColor = Color.Red;
                }
                else
                {
                    var producto = venta.buscarProductos(txtCodigo3.Text);
                    if (producto.Count > 0)
                    {
                        if (producto[0].existencia.Equals(0))
                        {
                            label_MensajeVenta.Text = "No hay productos en existencia";
                            label_MensajeVenta.ForeColor = Color.Red;
                        }
                        else
                        {
                            label_MensajeVenta.Text = "";
                            venta.guardarVentasTempo(txtCodigo10.Text, 0, tabControl1.SelectedIndex);
                            venta.buscarVentaTempo(dgv10, tabControl1.SelectedIndex);
                            venta.importes(lblTotal10, tabControl1.SelectedIndex);
                        }

                    }
                    else
                    {
                        label_MensajeVenta.Text = "No existe este producto ";
                        label_MensajeVenta.ForeColor = Color.Red;
                    }
                }
                txtCodigo10.Text = "";
                txtCodigo10.Focus();
            }
        }

        private void btnCobrar_Click_1(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            imprimir.printDocument(e, gb, tipo, dtp, usuario, pago, cambio, tabControl1.SelectedIndex);
        }

        private void restablecer()
        {
            txtPago.Text = "";
            txtCodigo.Text = "";
            venta.buscarVentaTempo(dgv, tabControl1.SelectedIndex);
            venta.importes(lblTotal, tabControl1.SelectedIndex);
        }

        //Venta 1 #####################################

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            valor = venta.pagosCliente(txtPago, label7, lblCambio, label4, lblTotal);
        }

        private void cbxHistorial_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHistorial.Checked)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void btnCobrarImp_Click(object sender, EventArgs e)
        {
            if (valor)
            {
                venta.cobrar(cbxHistorial, cbxTarjeta, txtPago, lblCambio, tabControl1.SelectedIndex, idCliente);
                gb = null;
                dtp = null;
                pago = txtPago.Text;
                cambio = lblCambio.Text;
                printDocument1.Print();
                restablecer();
            }
        }

        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvClient_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente = Convert.ToInt16(dgvClient.CurrentRow.Cells[0].Value);
        }
    }
}
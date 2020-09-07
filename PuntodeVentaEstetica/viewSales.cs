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
        private int idCliente = -1, idCliente2 = -1, idCliente3 = -1, idCliente4 = -1, idCliente5 = -1, idCliente6 = -1, idCliente7 = -1, idCliente8 = -1, idCliente9 = -1, idCliente10 = -1;
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
                panel3.Visible = false;
                cliente.buscarClienteDos(dgvCliente2, "");
            }
            else if (!tabControl1.Controls.Contains(tabPage3))
            {
                tabControl1.TabPages.Add(tabPage3);
                venta.buscarVentaTempo(dgv3, 2);
                venta.importes(lblTotal3, 2);
                panel4.Visible = false;
                cliente.buscarClienteDos(dgvCliente3, "");
            }
            else if (!tabControl1.Controls.Contains(tabPage4))
            {
                tabControl1.TabPages.Add(tabPage4);
                venta.buscarVentaTempo(dgv4, 3);
                venta.importes(lblTotal4, 3);
                panel5.Visible = false;
                cliente.buscarClienteDos(dgvCliente4, "");
            }
            else if (!tabControl1.Controls.Contains(tabPage5))
            {
                tabControl1.TabPages.Add(tabPage5);
                venta.buscarVentaTempo(dgv5, 4);
                venta.importes(lblTotal5, 4);
                panel6.Visible = false;
                cliente.buscarClienteDos(dgvCliente5, "");
            }
            else if (!tabControl1.Controls.Contains(tabPage6))
            {
                tabControl1.TabPages.Add(tabPage6);
                venta.buscarVentaTempo(dgv6, 5);
                venta.importes(lblTotal6, 5);
                panel7.Visible = false;
                cliente.buscarClienteDos(dgvCliente6, "");
            }
            else if (!tabControl1.Controls.Contains(tabPage7))
            {
                tabControl1.TabPages.Add(tabPage7);
                venta.buscarVentaTempo(dgv7, 6);
                venta.importes(lblTotal7, 6);
                panel8.Visible = false;
                cliente.buscarClienteDos(dgvCliente7, "");
            }
            else if (!tabControl1.Controls.Contains(tabPage8))
            {
                tabControl1.TabPages.Add(tabPage8);
                venta.buscarVentaTempo(dgv8, 7);
                venta.importes(lblTotal8, 7);
                panel9.Visible = false;
                cliente.buscarClienteDos(dgvCliente8, "");
            }
            else if (!tabControl1.Controls.Contains(tabPage9))
            {
                tabControl1.TabPages.Add(tabPage9);
                venta.buscarVentaTempo(dgv9, 8);
                venta.importes(lblTotal9, 8);
                panel10.Visible = false;
                cliente.buscarClienteDos(dgvCliente9, "");
            }
            else if (!tabControl1.Controls.Contains(tabPage10))
            {
                tabControl1.TabPages.Add(tabPage10);
                venta.buscarVentaTempo(dgv10, 9);
                venta.importes(lblTotal10, 9);
                panel11.Visible = false;
                cliente.buscarClienteDos(dgvCliente10, "");
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

        private void btnCobrar_Click_1(object sender, EventArgs e)
        {

        }

        private void checkBox9_ChangeUICues(object sender, UICuesEventArgs e)
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
            idCliente = -1;
            valor = false;
            txtPago.Text = "";
            txtCodigo.Text = "";
            venta.buscarVentaTempo(dgv, tabControl1.SelectedIndex);
            venta.importes(lblTotal, tabControl1.SelectedIndex);
        }

        private void restablecer2()
        {
            idCliente2 = -1;
            valor = false;
            txtPago2.Text = "";
            txtVenta2.Text = "";
            venta.buscarVentaTempo(dgv2, tabControl1.SelectedIndex);
            venta.importes(lblTotal2, tabControl1.SelectedIndex);
        }

        private void restablecer3()
        {
            idCliente3 = -1;
            valor = false;
            txtPago3.Text = "";
            txtCodigo3.Text = "";
            venta.buscarVentaTempo(dgv3, tabControl1.SelectedIndex);
            venta.importes(lblTotal3, tabControl1.SelectedIndex);
        }

        private void restablecer4()
        {
            idCliente4 = -1;
            valor = false;
            txtPago4.Text = "";
            txtCodigo4.Text = "";
            venta.buscarVentaTempo(dgv4, tabControl1.SelectedIndex);
            venta.importes(lblTotal4, tabControl1.SelectedIndex);
        }

        private void restablecer5()
        {
            idCliente5 = -1;
            valor = false;
            txtPago5.Text = "";
            txtCodigo5.Text = "";
            venta.buscarVentaTempo(dgv5, tabControl1.SelectedIndex);
            venta.importes(lblTotal5, tabControl1.SelectedIndex);
        }

        private void restablecer6()
        {
            idCliente6 = -1;
            valor = false;
            txtPago6.Text = "";
            txtCodigo6.Text = "";
            venta.buscarVentaTempo(dgv6, tabControl1.SelectedIndex);
            venta.importes(lblTotal6, tabControl1.SelectedIndex);
        }

        private void restablecer7()
        {
            idCliente7 = -1;
            valor = false;
            txtPago7.Text = "";
            txtCodigo7.Text = "";
            venta.buscarVentaTempo(dgv7, tabControl1.SelectedIndex);
            venta.importes(lblTotal7, tabControl1.SelectedIndex);
        }

        private void restablecer8()
        {
            idCliente8 = -1;
            valor = false;
            txtPago8.Text = "";
            txtCodigo8.Text = "";
            venta.buscarVentaTempo(dgv8, tabControl1.SelectedIndex);
            venta.importes(lblTotal8, tabControl1.SelectedIndex);
        }

        private void restablecer9()
        {
            idCliente9 = -1;
            valor = false;
            txtPago9.Text = "";
            txtCodigo9.Text = "";
            venta.buscarVentaTempo(dgv9, tabControl1.SelectedIndex);
            venta.importes(lblTotal9, tabControl1.SelectedIndex);
        }

        private void restablecer10()
        {
            idCliente10 = -1;
            valor = false;
            txtPago10.Text = "";
            txtCodigo10.Text = "";
            venta.buscarVentaTempo(dgv10, tabControl1.SelectedIndex);
            venta.importes(lblTotal10, tabControl1.SelectedIndex);
        }

        //Venta 1 #########################
        #region
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
            tabPage1.Text = Convert.ToString(dgvClient.CurrentRow.Cells[1].Value) + " " + Convert.ToString(dgvClient.CurrentRow.Cells[2].Value);
        }


        #endregion

        // VENTA 2 ########################
        #region

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
        private void txtVenta2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPago2_TextChanged(object sender, EventArgs e)
        {
            valor = venta.pagosCliente(txtPago2, lblSucambio2, lblCambio2, lblPagocon2, lblTotal2);
        }

        private void cbxHistorial2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHistorial2.Checked)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void dgvCliente2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente2 = Convert.ToInt16(dgvCliente2.CurrentRow.Cells[0].Value);
            tabPage2.Text = Convert.ToString(dgvCliente2.CurrentRow.Cells[1].Value) + " " + Convert.ToString(dgvCliente2.CurrentRow.Cells[2].Value);
        }   

        private void button3_Click(object sender, EventArgs e)
        {
            if (valor)
            {
                venta.cobrar(cbxHistorial2, cbxTarjeta2, txtPago2, lblCambio2, tabControl1.SelectedIndex, idCliente2);
                gb = null;
                dtp = null;
                pago = txtPago2.Text;
                cambio = lblCambio2.Text;
                printDocument1.Print();
                restablecer2();
            }
        }       

        #endregion

        //Venta 3 #########################
        #region
        private void txtCodigo3_TextChanged(object sender, EventArgs e)
        {
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

        private void txtPago3_TextChanged(object sender, EventArgs e)
        {
            valor = venta.pagosCliente(txtPago3, lblSucambio3, lblCambio3, lblPagocon3, lblTotal3);
        }

        private void cbxHistorial3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHistorial3.Checked)
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }
        }

        private void dgvCliente3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente3 = Convert.ToInt16(dgvCliente3.CurrentRow.Cells[0].Value);
            tabPage3.Text = Convert.ToString(dgvCliente3.CurrentRow.Cells[1].Value) + " " + Convert.ToString(dgvCliente3.CurrentRow.Cells[2].Value);
        }

        private void btnCobrarImp3_Click(object sender, EventArgs e)
        {
            if (valor)
            {
                venta.cobrar(cbxHistorial3, cbxTarjeta3, txtPago3, lblCambio3, tabControl1.SelectedIndex, idCliente3);
                gb = null;
                dtp = null;
                pago = txtPago3.Text;
                cambio = lblCambio3.Text;
                printDocument1.Print();
                restablecer3();
            }
        }

       

        #endregion

        //Venta 4 #########################
        #region
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

        private void cbxHistorial4_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHistorial4.Checked)
            {
                panel5.Visible = true;
            }
            else
            {
                panel5.Visible = false;
            }
        }

        private void dgvCliente4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente4 = Convert.ToInt16(dgvCliente4.CurrentRow.Cells[0].Value);
            tabPage4.Text = Convert.ToString(dgvCliente4.CurrentRow.Cells[1].Value) + " " + Convert.ToString(dgvCliente4.CurrentRow.Cells[2].Value);
        }

        private void txtPago4_TextChanged(object sender, EventArgs e)
        {
            valor = venta.pagosCliente(txtPago4, lblSucambio4, lblCambio4, lblPagocon4, lblTotal4);
        }

        private void btnCobrarImp4_Click(object sender, EventArgs e)
        {
            if (valor)
            {
                venta.cobrar(cbxHistorial4, cbxTarjeta4, txtPago4, lblCambio4, tabControl1.SelectedIndex, idCliente4);
                gb = null;
                dtp = null;
                pago = txtPago4.Text;
                cambio = lblCambio4.Text;
                printDocument1.Print();
                restablecer4();
            }
        }
        #endregion

        //Venta 5 #########################
        #region
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

        private void cbxHistorial5_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHistorial5.Checked)
            {
                panel6.Visible = true;
            }
            else
            {
                panel6.Visible = false;
            }
        }

        private void dgvCliente5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente5 = Convert.ToInt16(dgvCliente5.CurrentRow.Cells[0].Value);
            tabPage5.Text = Convert.ToString(dgvCliente5.CurrentRow.Cells[1].Value) + " " + Convert.ToString(dgvCliente5.CurrentRow.Cells[2].Value);
        }

        private void txtPago5_TextChanged(object sender, EventArgs e)
        {
            valor = venta.pagosCliente(txtPago5, lblSucambio5, lblCambio5, lblPagocon5, lblTotal5);
        }

        private void btnCobrarImp5_Click(object sender, EventArgs e)
        {
            if (valor)
            {
                venta.cobrar(cbxHistorial5, cbxTarjeta5, txtPago5, lblCambio5, tabControl1.SelectedIndex, idCliente5);
                gb = null;
                dtp = null;
                pago = txtPago5.Text;
                cambio = lblCambio5.Text;
                printDocument1.Print();
                restablecer5();
            }
        }

        #endregion

        // Venta 6 ########################
        #region

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

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHistorial6.Checked)
            {
                panel7.Visible = true;
            }
            else
            {
                panel7.Visible = false;
            }
        }

        private void dgvCliente6_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente6 = Convert.ToInt16(dgvCliente6.CurrentRow.Cells[0].Value);
            tabPage6.Text = Convert.ToString(dgvCliente6.CurrentRow.Cells[1].Value) + " " + Convert.ToString(dgvCliente6.CurrentRow.Cells[2].Value);
        }

        private void txtPago6_TextChanged(object sender, EventArgs e)
        {
            valor = venta.pagosCliente(txtPago6, lblSucambio6, lblCambio6, lblPagocon6, lblTotal6);
        }

        private void btnCobrarImp6_Click(object sender, EventArgs e)
        {
            if (valor)
            {
                venta.cobrar(cbxHistorial6, cbxTarjeta6, txtPago6, lblCambio6, tabControl1.SelectedIndex, idCliente6);
                gb = null;
                dtp = null;
                pago = txtPago6.Text;
                cambio = lblCambio6.Text;
                printDocument1.Print();
                restablecer6();
            }
        }

        #endregion

        //Venta 7 #########################
        #region

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

        private void cbxHistorial7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHistorial7.Checked)
            {
                panel8.Visible = true;
            }
            else
            {
                panel8.Visible = false;
            }
        }

        private void dgvCliente7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente7 = Convert.ToInt16(dgvCliente7.CurrentRow.Cells[0].Value);
            tabPage7.Text = Convert.ToString(dgvCliente7.CurrentRow.Cells[1].Value) + " " + Convert.ToString(dgvCliente7.CurrentRow.Cells[2].Value);
        }

        private void txtPago7_TextChanged(object sender, EventArgs e)
        {
            valor = venta.pagosCliente(txtPago7, lblSucambio7, lblCambio7, lblPagocon7, lblTotal7);
        }

        private void btnCobrarImp7_Click(object sender, EventArgs e)
        {
            if (valor)
            {
                venta.cobrar(cbxHistorial7, cbxTarjeta7, txtPago7, lblCambio7, tabControl1.SelectedIndex, idCliente7);
                gb = null;
                dtp = null;
                pago = txtPago7.Text;
                cambio = lblCambio7.Text;
                printDocument1.Print();
                restablecer7();
            }
        }

        #endregion

        //Venta 8 #########################
        #region

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

        private void cbxHistorial8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHistorial8.Checked)
            {
                panel9.Visible = true;
            }
            else
            {
                panel9.Visible = false;
            }
        }

        private void dgvCliente8_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente8 = Convert.ToInt16(dgvCliente8.CurrentRow.Cells[0].Value);
            tabPage8.Text = Convert.ToString(dgvCliente8.CurrentRow.Cells[1].Value) + " " + Convert.ToString(dgvCliente8.CurrentRow.Cells[2].Value);
        }

        private void txtPago8_TextChanged(object sender, EventArgs e)
        {
            valor = venta.pagosCliente(txtPago8, lblSucambio8, lblCambio8, lblPagocon8, lblTotal8);
        }

        private void btnCobrarImp8_Click(object sender, EventArgs e)
        {
            if (valor)
            {
                venta.cobrar(cbxHistorial8, cbxTarjeta8, txtPago8, lblCambio8, tabControl1.SelectedIndex, idCliente8);
                gb = null;
                dtp = null;
                pago = txtPago8.Text;
                cambio = lblCambio8.Text;
                printDocument1.Print();
                restablecer8();
            }
        }

        #endregion

        //Venta 9 #########################
        #region

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

        private void cbxHistorial9_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHistorial9.Checked)
            {
                panel10.Visible = true;
            }
            else
            {
                panel10.Visible = false;
            }
        }

        private void dgvCliente9_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente9 = Convert.ToInt16(dgvCliente9.CurrentRow.Cells[0].Value);
            tabPage9.Text = Convert.ToString(dgvCliente9.CurrentRow.Cells[1].Value) + " " + Convert.ToString(dgvCliente9.CurrentRow.Cells[2].Value);
        }

        private void txtPago9_TextChanged(object sender, EventArgs e)
        {
            valor = venta.pagosCliente(txtPago9, lblSucambio9, lblCambio9, lblPagocon9, lblTotal9);
        }

        private void btnCobrarImp9_Click(object sender, EventArgs e)
        {
            if (valor)
            {
                venta.cobrar(cbxHistorial9, cbxTarjeta9, txtPago9, lblCambio9, tabControl1.SelectedIndex, idCliente9);
                gb = null;
                dtp = null;
                pago = txtPago9.Text;
                cambio = lblCambio9.Text;
                printDocument1.Print();
                restablecer9();
            }
        }

        #endregion

        //Venta 10 ########################
        #region

        private void cbxHistorial10_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHistorial10.Checked)
            {
                panel11.Visible = true;
            }
            else
            {
                panel11.Visible = false;
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

        private void dgvCliente10_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idCliente10 = Convert.ToInt16(dgvCliente10.CurrentRow.Cells[0].Value);
            tabPage10.Text = Convert.ToString(dgvCliente10.CurrentRow.Cells[1].Value) + " " + Convert.ToString(dgvCliente10.CurrentRow.Cells[2].Value);
        }

        private void txtPago10_TextChanged(object sender, EventArgs e)
        {
            valor = venta.pagosCliente(txtPago10, lblSucambio10, lblCambio10, lblPagocon10, lblTotal10);
        }

        private void btnCobrarImp10_Click(object sender, EventArgs e)
        {
            if (valor)
            {
                venta.cobrar(cbxHistorial10, cbxTarjeta10, txtPago10, lblCambio10, tabControl1.SelectedIndex, idCliente10);
                gb = null;
                dtp = null;
                pago = txtPago10.Text;
                cambio = lblCambio10.Text;
                printDocument1.Print();
                restablecer10();
            }
        }

        #endregion
    }
}
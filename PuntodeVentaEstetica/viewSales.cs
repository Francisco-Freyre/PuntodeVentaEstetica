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
            }
            else if (!tabControl1.Controls.Contains(tabPage3))
            {
                tabControl1.TabPages.Add(tabPage3);
            }
            else if (!tabControl1.Controls.Contains(tabPage4))
            {
                tabControl1.TabPages.Add(tabPage4);
            }
            else if (!tabControl1.Controls.Contains(tabPage5))
            {
                tabControl1.TabPages.Add(tabPage5);
            }
            else if (!tabControl1.Controls.Contains(tabPage6))
            {
                tabControl1.TabPages.Add(tabPage6);
            }
            else if (!tabControl1.Controls.Contains(tabPage7))
            {
                tabControl1.TabPages.Add(tabPage7);
            }
            else if (!tabControl1.Controls.Contains(tabPage8))
            {
                tabControl1.TabPages.Add(tabPage8);
            }
            else if (!tabControl1.Controls.Contains(tabPage9))
            {
                tabControl1.TabPages.Add(tabPage9);
            }
            else if (!tabControl1.Controls.Contains(tabPage10))
            {
                tabControl1.TabPages.Add(tabPage10);
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

        
    }
}

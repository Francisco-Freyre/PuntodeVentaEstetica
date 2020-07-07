using PuntodeVentaEstetica.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVentaEstetica
{
    public partial class viewProducts : Form
    {
        private Producto p = new Producto();
        private int idCategoria, idProducto;

        public viewProducts()
        {
            InitializeComponent();
            restablecer();
            restablecerProd();
            cbCategoria.DataSource = p.GetCategorias();
            cbCategoria.DisplayMember = "categoria";
        }

        private void restablecer()
        {
            txtCat.Text = "";
            lblCat.Text = "Categoria";
            lblCat.ForeColor = Color.LightSlateGray;
            p.buscarCat(dgvCats, "");
        }

        private void restablecerProd()
        {
            txtCodigo.Focus();
            lblCodigo.Text = "Codigo de barras:";
            lblDescripcion.Text = "Descripcion:";
            lblCosto.Text = "Costo:";
            lblPrecioVenta.Text = "Precio en venta:";
            lblExistencia.Text = "Existencia:";
            lblCategoriaProducto.Text = "Categoria:";
            lblMinimo.Text = "Minimo:";
            lblDescripcion.ForeColor = Color.LightSlateGray;
            lblCosto.ForeColor = Color.LightSlateGray;
            lblCodigo.ForeColor = Color.LightSlateGray;
            lblPrecioVenta.ForeColor = Color.LightSlateGray;
            lblExistencia.ForeColor = Color.LightSlateGray;
            lblCategoriaProducto.ForeColor = Color.LightSlateGray;
            lblMinimo.ForeColor = Color.LightSlateGray;
            txtCodigo.Text = "";
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtExistencia.Text = "";
            txtMinimo.Text = "";
            p.buscarProducto(dgvProductos, "");
        }

        //Codigo de categorias #################################
        #region
        private void btnCatGuardar_Click(object sender, EventArgs e)
        {
            if(txtCat.Text == "")
            {
                lblCat.Text = "Escriba un nombre para la categoria";
                lblCat.ForeColor = Color.Red;
                txtCat.Focus();
            }
            else
            {
                p.insertarCat(txtCat.Text);
                restablecer();
            }
        }

        private void btnCatCancel_Click(object sender, EventArgs e)
        {
            restablecer();
        }

        private void dgvCats_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCats.Rows.Count != 0)
            {
                idCategoria = Convert.ToInt16(dgvCats.CurrentRow.Cells[0].Value);
            }
        }

        private void btnCatEliminar_Click(object sender, EventArgs e)
        {
            p.eliminarCat(idCategoria);
            restablecer();
        }
        #endregion

        

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                lblCodigo.Text = "Ingrese un codigo de barras";
                lblCodigo.ForeColor = Color.Red;
                txtCodigo.Focus();
            }
            else
            {
                if (txtDescripcion.Text == "")
                {
                    lblDescripcion.Text = "Ingrese una descripcion";
                    lblDescripcion.ForeColor = Color.Red;
                    txtDescripcion.Focus();
                }
                else
                {
                    if (txtCosto.Text == "")
                    {
                        lblCosto.Text = "Ingrese el costo";
                        lblCosto.ForeColor = Color.Red;
                        txtCosto.Focus();
                    }
                    else
                    {
                        if (txtPrecioVenta.Text == "")
                        {
                            lblPrecioVenta.Text = "Ingrese el precio de venta";
                            lblPrecioVenta.ForeColor = Color.Red;
                            txtPrecioVenta.Focus();
                        }
                        else
                        {
                            if (txtExistencia.Text == "")
                            {
                                lblExistencia.Text = "Ingrese alguna existencia";
                                lblExistencia.ForeColor = Color.Red;
                                txtExistencia.Focus();
                            }
                            else
                            {
                                if (txtMinimo.Text == "")
                                {
                                    lblMinimo.Text = "Ingresa una cantidad minima";
                                    lblMinimo.ForeColor = Color.Red;
                                    txtMinimo.Focus();
                                }
                                else
                                {
                                    p.guardarProducto(txtCodigo.Text, txtDescripcion.Text, Convert.ToDecimal(txtCosto.Text), Convert.ToDecimal(txtPrecioVenta.Text),
                                        Convert.ToInt16(txtExistencia.Text), Convert.ToInt16(txtMinimo.Text), cbCategoria.Text);
                                    restablecerProd();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            restablecerProd();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Rows.Count != 0)
            {
                idProducto = Convert.ToInt16(dgvProductos.CurrentRow.Cells[0].Value);
                txtCodigo.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[1].Value);
                txtDescripcion.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[2].Value);
                txtCosto.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[3].Value);
                txtPrecioVenta.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[4].Value);
                txtExistencia.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[5].Value);
                txtMinimo.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[6].Value);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            p.buscarProducto(dgvProductos, textBox1.Text);
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            p.borrarProducto(idProducto);
            restablecerProd();
        }

        
    }
}

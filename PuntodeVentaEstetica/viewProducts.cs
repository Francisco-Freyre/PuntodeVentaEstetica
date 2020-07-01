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

        public viewProducts()
        {
            InitializeComponent();
            
        }
        

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
                p.buscarCat(dgvCats, "");
                txtCat.Text = "";
                lblCat.Text = "Categoria";
                lblCat.ForeColor = Color.LightSlateGray;
            }
        }
    }
}

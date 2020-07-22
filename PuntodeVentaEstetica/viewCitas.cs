using PuntodeVentaEstetica.Controller;
using PuntodeVentaEstetica.Model;
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
    public partial class viewCitas : Form
    {
        private Cita cita = new Cita();
        public viewCitas()
        {
            InitializeComponent();
            restablecer();
        }

        public void restablecer()
        {
            lblNombre.Text = "Nombre:";
            lblTelefono.Text = "Telefono:";
            lblServicio.Text = "Servicio:";
            lblFecha.Text = "Fecha:";
            lblHora.Text = "Hora:";

            lblNombre.ForeColor = Color.LightSlateGray;
            lblTelefono.ForeColor = Color.LightSlateGray;
            lblServicio.ForeColor = Color.LightSlateGray;
            lblFecha.ForeColor = Color.LightSlateGray;
            lblHora.ForeColor = Color.LightSlateGray;

            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtServicio.Text = "";

            cita.buscarCitas(dgv, "");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                lblNombre.Text = "Ingresar un nombre";
                lblNombre.ForeColor = Color.Red;
                txtNombre.Focus();
            }
            else if (txtTelefono.Text == "")
            {
                lblTelefono.Text = "Ingresar un telefono";
                lblTelefono.ForeColor = Color.Red;
                txtTelefono.Focus();
            }
            else if (txtServicio.Text == "")
            {
                lblServicio.Text = "Ingresar un servicio";
                lblServicio.ForeColor = Color.Red;
                txtServicio.Focus();
            }
            else
            {
                cita.guardarCita(txtNombre.Text, txtTelefono.Text, txtServicio.Text, dtp, cbHoras.Text + ":" + cbMinutos.Text);
                restablecer();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cita.buscarCitas(dgv, textBox1.Text);
        }
    }
}

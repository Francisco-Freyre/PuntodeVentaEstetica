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
        private int idCita = 0;
        private Cita cita = new Cita();
        public viewCitas()
        {
            InitializeComponent();
            restablecer();
            cbxUsuario.DataSource = cita.GetUsuarios();
            cbxUsuario.DisplayMember = "nombre";
            cbxUsuarios2.DataSource = cita.GetUsuarios();
            cbxUsuarios2.DisplayMember = "nombre";
        }

        public void restablecer()
        {
            idCita = 0;
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

            cita.buscarCitas(dgv, cbxUsuarios2.Text, dtp2);
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
                cita.guardarCita(txtNombre.Text, txtTelefono.Text, txtServicio.Text, dtp, cbHoras.Text + ":" + cbMinutos.Text, cbxUsuario.Text);
                restablecer();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            cita.buscarCitas(dgv, cbxUsuarios2.Text, dtp2);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count != 0)
            {
                idCita = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                txtNombre.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
                txtTelefono.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
                txtServicio.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cita.borrar(idCita);
            restablecer();
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            cita.buscarCitas(dgv, cbxUsuarios2.Text, dtp2);
        }

        private void cbxUsuarios2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxUsuarios2_SelectedValueChanged(object sender, EventArgs e)
        {
            cita.buscarCitas(dgv, cbxUsuarios2.Text, dtp2);
        }
    }
}

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
    public partial class viewCustomer : Form
    {
        private Cliente Cliente = new Cliente();
        private int idCliente;
        public viewCustomer()
        {
            InitializeComponent();
            restablecer();
        }

        private void restablecer()
        {
            idCliente = 0;
            lblNombre.Text = "Nombre:";
            lblNombre.ForeColor = Color.LightSlateGray;
            lblApellido.Text = "Apellido:";
            lblApellido.ForeColor = Color.LightSlateGray;
            lblTelefono.Text = "Telefono:";
            lblTelefono.ForeColor = Color.LightSlateGray;
            lblDireccion.Text = "Direccion:";
            lblDireccion.ForeColor = Color.LightSlateGray;
            lblCorreo.Text = "Correo:";
            lblCorreo.ForeColor = Color.LightSlateGray;
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            Cliente.buscarCliente(dgvClientes, "");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                lblNombre.Text = "Ingrese el nombre del cliente";
                lblNombre.ForeColor = Color.Red;
                txtNombre.Focus();
            }
            else if(txtApellido.Text == "")
            {
                lblApellido.Text = "Ingrese el apellido del cliente";
                lblApellido.ForeColor = Color.Red;
                txtApellido.Focus();
            }
            else if (txtTelefono.Text == "")
            {
                lblTelefono.Text = "Ingrese el telefono del cliente";
                lblTelefono.ForeColor = Color.Red;
                txtTelefono.Focus();
            }
            else if (txtDireccion.Text == "")
            {
                lblDireccion.Text = "Ingrese la direccion del cliente";
                lblDireccion.ForeColor = Color.Red;
                txtDireccion.Focus();
            }
            else if (txtCorreo.Text == "")
            {
                lblCorreo.Text = "Ingrese un correo";
                lblCorreo.ForeColor = Color.Red;
                txtCorreo.Focus();
            }
            else
            {
                if (idCliente == 0)
                {
                    Cliente.insertarCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text);
                }
                else
                {
                    Cliente.updateCliente(txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtTelefono.Text, txtCorreo.Text, idCliente);
                }
                restablecer();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            restablecer();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente.borrarCliente(idCliente);
            restablecer();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvClientes.Rows.Count != 0)
            {
                idCliente = Convert.ToInt16(dgvClientes.CurrentRow.Cells[0].Value);
                txtNombre.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[1].Value);
                txtApellido.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[2].Value);
                txtTelefono.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[3].Value);
                txtDireccion.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[4].Value);
                txtCorreo.Text = Convert.ToString(dgvClientes.CurrentRow.Cells[5].Value);
            }
        }
    }
}

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
    public partial class viewUsers : Form
    {
        private int idusuarioeliminar = -1;
        private object[] textBoxObject, labelsObject;
        public viewUsers()
        {
            InitializeComponent();

            object[] textBoxObject = {
                txtUsuarioNombre, txtUsuarioApellido, txtUsuarioUser, txtUsuarioPass
            };
            object[] labelsObject = {
                lblNombreUsuario, lblUsuarioApellido, lblUsuarioUser, lblUsuarioPass
            };

            this.textBoxObject = textBoxObject;
            this.labelsObject = labelsObject;

            inicio();
        }

        private void inicio()
        {
            var usuario = new Usuario(textBoxObject, labelsObject, dgvUsuarios);
            usuario.restablecerUsuarios();
        }

        private void btnUsuarioGuardar_Click_1(object sender, EventArgs e)
        {
            var usuario = new Usuario(textBoxObject, labelsObject, dgvUsuarios);

            if (usuario.registrarUsuario())
            {
                usuario.restablecerUsuarios();
            }
        }

        private void btnUsuarioCancel_Click(object sender, EventArgs e)
        {
            inicio();
        }

        private void dgvUsuarios_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.Rows.Count != 0)
            {
                var usuario = new Usuario(textBoxObject, labelsObject, dgvUsuarios);
                usuario.dataGridViewUsuarios();
                idusuarioeliminar = Convert.ToInt16(dgvUsuarios.CurrentRow.Cells[0].Value);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            var usuario = new Usuario(textBoxObject, labelsObject, dgvUsuarios);
            usuario.eliminarUsuario(idusuarioeliminar);
            usuario.restablecerUsuarios();
        }

    }
}

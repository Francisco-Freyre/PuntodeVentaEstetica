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
    public partial class Form1 : Form
    {
        private int idusuarioeliminar = -1;
        private object[] textBoxObject, labelsObject;
        public Form1()
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
        }

        //Metodos para la parte de usuarios ####################################
        #region

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 4;
            var usuario = new Usuario(textBoxObject, labelsObject, dgvUsuarios);
            usuario.restablecerUsuarios();
        }
        private void btnUsuarioGuardar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario(textBoxObject, labelsObject, dgvUsuarios);

            if (usuario.registrarUsuario())
            {
                usuario.restablecerUsuarios();
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsuarios.Rows.Count != 0)
            {
                var usuario = new Usuario(textBoxObject, labelsObject, dgvUsuarios);
                usuario.dataGridViewUsuarios();
                idusuarioeliminar = Convert.ToInt16(dgvUsuarios.CurrentRow.Cells[0].Value);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario(textBoxObject, labelsObject, dgvUsuarios);
            usuario.eliminarUsuario(idusuarioeliminar);
            usuario.restablecerUsuarios();
        }
        #endregion

        //Metodos para la animacion del SideBar ###################################
        #region
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (bunifuGradientPanel1.Width == 225)
            {
                bunifuGradientPanel1.Visible = false;
                bunifuGradientPanel1.Width = 68;
                SideBar.Width = 90;
                AnimationSidebar.Show(bunifuGradientPanel1);
            }
            else
            {
                bunifuGradientPanel1.Visible = false;
                bunifuGradientPanel1.Width = 225;
                SideBar.Width = 250;
                AnimationSideBarBack.Show(bunifuGradientPanel1);
            }
        }
        #endregion

        //Metodos creados por error sin funcion ########################
        #region
        private void contenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

    }
}

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
        private Form formularioActivo = null;
        public Form1()
        {
            InitializeComponent();
            abrirFormulario(new viewEntry());
        }

        private void abrirFormulario(Form formhijo)
        {
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formhijo;
            formhijo.TopLevel = false;
            formhijo.FormBorderStyle = FormBorderStyle.None;
            formhijo.Dock = DockStyle.Fill;
            contenido.Controls.Add(formhijo);
            contenido.Tag = formhijo;
            formhijo.BringToFront();
            formhijo.Show();
        }

        //Llmados a todos los formularios ##########################################
        #region

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            abrirFormulario(new viewUsers());
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            abrirFormulario(new viewProducts());
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            abrirFormulario(new viewCustomer());
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            abrirFormulario(new viewEntry());
        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            abrirFormulario(new viewCitas());
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

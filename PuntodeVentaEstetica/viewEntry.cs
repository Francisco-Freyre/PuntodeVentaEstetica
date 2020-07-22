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
    public partial class viewEntry : Form
    {
        private Asistencia Asistencia = new Asistencia();
        private Timer ti;
        public viewEntry()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
            Asistencia.mostrar(dgvAsistencias);
        }

        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hora = DateTime.Now;
            lblHora.Text = hora.ToString("HH:mm:ss");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtId.Text == "")
            {
                lblId.Text = "Ingrese el identificador de usuario";
                lblId.ForeColor = Color.Red;
                txtId.Focus();
            }
            else
            {
                Asistencia.insertar(Convert.ToInt16(txtId.Text));
                Asistencia.mostrar(dgvAsistencias);
            }
        }
    }
}

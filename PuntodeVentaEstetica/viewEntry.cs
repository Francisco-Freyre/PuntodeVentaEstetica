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
        private Timer ti;
        public viewEntry()
        {
            ti = new Timer();
            ti.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            ti.Enabled = true;
        }

        private void eventoTimer(object ob, EventArgs evt)
        {
            DateTime hora = DateTime.Now;
            lblHora.Text = hora.ToString("hh:mm:ss tt");
        }
    }
}

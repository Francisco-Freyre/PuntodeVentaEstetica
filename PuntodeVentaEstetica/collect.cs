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
    
    public partial class collect : Form
    {
        private int Numeroventa;
        public collect(Label total, int venta)
        {
            InitializeComponent();
            this.lblTotal = total;
            this.Numeroventa = venta;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

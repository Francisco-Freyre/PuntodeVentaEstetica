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
    public partial class viewVentas : Form
    {
        int idProducto;
        private Inventario inventario = new Inventario();
        public viewVentas()
        {
            InitializeComponent();
            inventario.getProducto(txtBuscar.Text, cbxAgotados, lblCostoInv, lblGananciaInv, dgv);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            inventario.getProducto(txtBuscar.Text, cbxAgotados, lblCostoInv, lblGananciaInv, dgv);
        }

        private void cbxAgotados_CheckedChanged(object sender, EventArgs e)
        {
            inventario.getProducto(txtBuscar.Text, cbxAgotados, lblCostoInv, lblGananciaInv, dgv);
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv.Rows.Count != 0)
            {
                idProducto = Convert.ToInt16(dgv.CurrentRow.Cells[0].Value);
                txtExistencia.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            inventario.updateExistencia(txtExistencia.Text, idProducto);
            inventario.getProducto(txtBuscar.Text, cbxAgotados, lblCostoInv, lblGananciaInv, dgv);
            txtExistencia.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtExistencia.Text = "";
            txtBuscar.Text = "";
            cbxAgotados.Checked = false;
            inventario.getProducto(txtBuscar.Text, cbxAgotados, lblCostoInv, lblGananciaInv, dgv);
        }

        private void dgv_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int existencia = (int)dgv.Rows[e.RowIndex].Cells[5].Value;
            int minimo = (int)dgv.Rows[e.RowIndex].Cells[6].Value;
            if (existencia <= minimo)
            {
                dgv.Rows[e.RowIndex].Cells[5].Style.ForeColor = Color.Red;
            }
            else
            {
                dgv.Rows[e.RowIndex].Cells[5].Style.ForeColor = Color.Green;
            }
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            inventario.buscarVentas(txtBuscar2.Text, dtpInicio, dtpFinal, cbxVendidos, dgv2);
        }

        private void dtpFinal_ValueChanged(object sender, EventArgs e)
        {
            inventario.buscarVentas(txtBuscar2.Text, dtpInicio, dtpFinal, cbxVendidos, dgv2);
        }

        private void cbxVendidos_CheckedChanged(object sender, EventArgs e)
        {
            inventario.buscarVentas(txtBuscar2.Text, dtpInicio, dtpFinal, cbxVendidos, dgv2);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Type officeType = Type.GetTypeFromProgID("Excel.Application");
            if (officeType == null)
            {
                MessageBox.Show("Es necesario que tenga Excel instalado para poder exportar.", "Punto Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dgv.Rows.Count != 0)
                {
                    String[] tutlulo = { "Codigo", "Descripcion", "Costo", "Precio de venta", "Existencia", "Categoria" };
                    int[] column = { 0, 6 };
                    Exportar.exportarDataGridViewExcel(dgv, tutlulo, column);
                }
            }
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            if (dgv.Rows.Count != 0)
            {
                String[] tutlulo = { "Codigo", "Descripcion", "Costo", "Precio de venta", "Existencia", "Categoria" };
                int[] column = { 0, 6 };
                Exportar.exportarDataGridViewPDF(dgv, tutlulo, column);
            }
        }

        private void btnExcel2_Click(object sender, EventArgs e)
        {
            Type officeType = Type.GetTypeFromProgID("Excel.Application");
            if (officeType == null)
            {
                MessageBox.Show("Es necesario que tenga Excel instalado para poder exportar.", "Punto Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dgv2.Rows.Count != 0)
                {
                    String[] tutlulo = { "Codigo", "Descripcion", "Precio", "Cantidad", "Importe", "Costo", "Categoria" };
                    int[] column = { 0, 1, 9, 10 };
                    Exportar.exportarDataGridViewExcel(dgv2, tutlulo, column);
                }
            }
        }

        private void btnPdf2_Click(object sender, EventArgs e)
        {
            if (dgv2.Rows.Count != 0)
            {
                String[] tutlulo = { "Codigo", "Descripcion", "Precio", "Cantidad", "Importe", "Costo", "Categoria" };
                int[] column = { 0, 1, 9, 10 };
                Exportar.exportarDataGridViewPDF(dgv2, tutlulo, column);
            }
        }
    }
}

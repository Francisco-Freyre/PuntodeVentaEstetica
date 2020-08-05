using LinqToDB;
using PuntodeVentaEstetica.Connection;
using PuntodeVentaEstetica.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVentaEstetica.Controller
{
    class Ventas : Conexion
    {
        private Decimal importe = 0, totalPagar = 0m, ingresos, ingresosTotales;
        private string fecha = DateTime.Now.ToString("dd/MMM/yyy");

        public List<productos> buscarProductos(string codigo)
        {
            return productos.Where(p => p.codigo.Equals(codigo)).ToList();
        }

        public void guardarVentasTempo(string codigo, int funcion, int venta)
        {
            string importe, precios;
            int cantidad = 1, existencia;
            Decimal precio, importes;

            var ventaTempo = tempoVentas.Where(t => t.codigo.Equals(codigo) && t.venta.Equals(venta)).ToList();
            var product = productos.Where(p => p.codigo.Equals(codigo)).ToList();
            precio = Convert.ToDecimal(product[0].precioVenta);
            precios = String.Format("${0:#,###,###,##0.00####}", precio);
            if (ventaTempo.Count() > 0)
            {
                cantidad = ventaTempo[0].cantidad;
                if (funcion == 0)
                {
                    cantidad += 1;
                }
                else
                {
                    cantidad--;
                }
                importes = precio * cantidad;
                importe = String.Format("${0:#,###,###,##0.00####}", importes);
                tempoVentas.Where(t => t.idTempo.Equals(ventaTempo[0].idTempo))
                                .Set(t => t.precio, precios)
                                .Set(t => t.cantidad, cantidad)
                                .Set(t => t.importe, importe)
                                .Update();
            }
            else
            {
                tempoVentas.Value(t => t.codigo, product[0].codigo)
                            .Value(t => t.descripcion, product[0].descripcion)
                            .Value(t => t.precio, precios)
                            .Value(t => t.cantidad, 1)
                            .Value(t => t.importe, precios)
                            .Value(t => t.costo, Convert.ToString(product[0].costo))
                            .Value(t => t.categoria, product[0].categoria)
                            .Value(t => t.venta, venta)
                            .Insert();
            }
            existencia = product[0].existencia;
            if (existencia == 0)
            {

            }
            else
            {
                existencia--;
                productos.Where(p => p.idProducto.Equals(product[0].idProducto))
                .Set(t => t.existencia, existencia)
                .Update();
            }
        }

        public void buscarVentaTempo(DataGridView dataGridView, int venta)
        {
            var query = tempoVentas.Where(t => t.venta.Equals(venta)).ToList();
            dataGridView.DataSource = query;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[8].Visible = false;
            dataGridView.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView.Columns[5].DefaultCellStyle.ForeColor = Color.Green;
        }

        internal void importes(Label label, int venta)
        {
            importe = 0;
            var ventaTempo = tempoVentas.Where(t => t.venta.Equals(venta)).ToList();
            if (ventaTempo.Count > 0)
            {
                ventaTempo.ForEach(item => {
                    importe += Convert.ToDecimal(item.importe.Replace("$", ""));
                });
                label.Text = String.Format("${0:#,###,###,##0.00####}", importe);
            }
            else
            {
                label.Text = "$0.00";
            }
        }
    }
}

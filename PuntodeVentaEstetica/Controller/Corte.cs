using PuntodeVentaEstetica.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVentaEstetica.Controller
{
    class Corte : Conexion
    {
        internal void cortesGlobales(Label label, Label label2, Label label3, Label label4, Label label5, Label label6, DateTimePicker dateTimePicker)
        {
            int cant = 0;
            var fecha_inicio = dateTimePicker.Value.Date.ToString("dd/MMM/yyy");
            Decimal importe, importe2 = 0, ganancia = 0, total = 0, totalsalidas = 0, totalcaja = 0, cost = 0, totalentradas = 0;
            importe = 0;
            var inicio = ingresos.Where(e => e.fecha.Equals(fecha_inicio)).ToList();
            if (inicio.Count > 0)
            {
                label.Text = String.Format("${0:#,###,###,##0.00####}", inicio[0].ingresoInicial.Replace("$","")); ;
                label2.Text = "$0.00";
                label3.Text = "$0.00";
            }
            else
            {
                label.Text = "$0.00";
                label2.Text = "$0.00";
                label3.Text = "$0.00";
            }
            var venta = Ventas.Where(t => t.fecha.Equals(fecha_inicio)).ToList();
            if (venta.Count > 0)
            {
                venta.ForEach(item => {
                    total = Convert.ToDecimal(item.importe.Replace("$", "")) - (Convert.ToDecimal(item.costo) * item.cantidad);
                    ganancia += total;
                    importe += Convert.ToDecimal(item.importe.Replace("$", ""));
                    cant += item.cantidad;
                    cost += Convert.ToDecimal(item.costo);
                });
                label4.Text = String.Format("${0:#,###,###,##0.00####}", importe);
            }
            else
            {
                label4.Text = "$0.00";
            }
            var tarjeta = ventasTarjeta.Where(t => t.fecha.Equals(fecha_inicio)).ToList();
            if(tarjeta.Count > 0)
            {
                tarjeta.ForEach(item =>
                {
                    importe2 += Convert.ToDecimal(item.importe.Replace("$", ""));
                });
                label5.Text = String.Format("${0:#,###,###,##0.00####}", importe2);
            }
            else
            {
                label5.Text = "$0.00";
            }
            /*var salidas = salidasdinero.Where(s => s.Fecha.Equals(fecha_inicio)).ToList();
            if (salidas.Count != 0)
            {
                salidas.ForEach(item =>
                {
                    totalsalidas += Convert.ToDecimal(item.Monto.Replace("$", ""));
                });
                label15.Text = String.Format("${0:#,###,###,##0.00####}", totalsalidas);
                label16.Text = String.Format("${0:#,###,###,##0.00####}", totalsalidas);
                label17.Text = String.Format("${0:#,###,###,##0.00####}", totalsalidas);
            }*/
            total = importe;
            totalcaja = total - totalsalidas + totalentradas + Convert.ToDecimal(inicio[0].ingresoInicial.Replace("$", ""));
            label6.Text = String.Format("${0:#,###,###,##0.00####}", totalcaja);
        }
    }
}

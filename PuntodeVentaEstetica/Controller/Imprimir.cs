using LinqToDB;
using PuntodeVentaEstetica.Connection;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVentaEstetica.Controller
{
    class Imprimir : Conexion
    {
        public void printDocument(PrintPageEventArgs e, GroupBox groupBox, string tipo, DateTimePicker dateTimePicker, string usuario, string pago, string cambio, int numeroVenta)
        {
            if (groupBox != null)
            {
                Bitmap bm = new Bitmap(groupBox.Width, groupBox.Height);
                groupBox.DrawToBitmap(bm, new Rectangle(0, 0, groupBox.Width, groupBox.Height));
                e.Graphics.DrawImage(bm, 0, 0);
            }
            else
            {
                switch (tipo)
                {
                    case "venta":
                        int pos = 140, ultimo = 0;
                        Decimal importe = 0;
                        string hora = DateTime.Now.ToString("hh:mm:ss");
                        Font f1 = new Font("Arial", 9, FontStyle.Regular);
                        Font f2 = new Font("Arial", 7, FontStyle.Regular);
                        var ultimoTicket = Ventas.Where(v => v.fecha.Equals(DateTime.Now.ToString("dd/MMM/yyy"))).OrderByDescending(v => v.numeroTicket).ToList();
                        if (ultimoTicket.Count != 0) { ultimo = ultimoTicket[0].numeroTicket; }
                        else
                        {
                            ultimoTicket = Ventas.OrderByDescending(v => v.numeroTicket).ToList();
                            ultimo = ultimoTicket[0].numeroTicket;
                        }
                        Ventas.Where(v => v.numeroTicket.Equals(ultimo)).Set(v => v.hora, hora).Update();
                        e.Graphics.DrawString(String.Format("Beauty Life Studio"), f1, Brushes.Black, 5, 10);
                        e.Graphics.DrawString(String.Format("Carretera mezquital #504"), f1, Brushes.Black, 5, 35);
                        e.Graphics.DrawString(String.Format("Prolongacion nazas, local 1  "), f1, Brushes.Black, 5, 60);
                        e.Graphics.DrawString(String.Format("Numero de ticket: " + ultimo), f1, Brushes.Black, 5, 85);
                        e.Graphics.DrawString(String.Format(hora), f1, Brushes.Black, 140, 85);
                        e.Graphics.DrawString(String.Format("________________________________________"), f2, Brushes.Black, 1, 95);
                        e.Graphics.DrawString(String.Format("Producto"), f2, Brushes.Black, 10, 110);
                        e.Graphics.DrawString(String.Format("Cantidad"), f2, Brushes.Black, 90, 110);
                        e.Graphics.DrawString(String.Format("Precio"), f2, Brushes.Black, 150, 110);
                        e.Graphics.DrawString(String.Format("________________________________________"), f2, Brushes.Black, 1, 115);
                        var ventaTempo = tempoVentas.Where(t => t.venta.Equals(numeroVenta)).ToList();
                        if (0 < ventaTempo.Count)
                        {
                            ventaTempo.ForEach(item => {

                                e.Graphics.DrawString(item.descripcion, f2, Brushes.Black, 10, pos);
                                e.Graphics.DrawString(item.cantidad.ToString(), f2, Brushes.Black, 117, pos);
                                e.Graphics.DrawString(item.importe, f2, Brushes.Green, 150, pos);
                                pos += 25;
                                importe += Convert.ToDecimal(item.importe.Replace("$", ""));

                                tempoVentas.Where(p => p.idTempo.Equals(item.idTempo) && p.venta.Equals(numeroVenta)).Delete();
                            });
                            e.Graphics.DrawString(String.Format("________________________________________"), f2, Brushes.Black, 1, pos);
                            pos += 25;
                            e.Graphics.DrawString("Total: ", f2, Brushes.Green, 25, pos - 10);
                            e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", importe), f2, Brushes.Black, 100, pos - 10);
                            pos += 25;
                            e.Graphics.DrawString("Pago con: ", f2, Brushes.Green, 25, pos - 20);
                            e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", pago), f2, Brushes.Black, 90, pos - 20);
                            pos += 25;
                            e.Graphics.DrawString("Su cambio: ", f2, Brushes.Green, 25, pos - 20);
                            e.Graphics.DrawString(string.Format(cambio), f2, Brushes.Black, 90, pos - 20);
                            pos += 25;
                            e.Graphics.DrawString(String.Format("________________________________________"), f2, Brushes.Black, 1, pos - 40);
                        }
                        e.Graphics.DrawString(String.Format("Este recibo no tiene nungun valor fiscal"), f2, Brushes.Black, 5, pos - 25);
                        break;

                    case "cortediario":
                        int cant1 = 0, pasi1 = 185;
                        var fecha_inicio1 = dateTimePicker.Value.Date.ToString("dd/MMM/yyy");
                        Decimal ganancia1 = 0, totalsalidas1 = 0, totalcaja1 = 0, cost1 = 0, costoTotal1 = 0;
                        importe = 0;
                        var inicio = ingresos.Where(t => t.fecha.Equals(fecha_inicio1)).ToList();
                        var salida = salidas.Where(t => t.fecha.Equals(fecha_inicio1)).ToList();
                        var entrada = entradas.Where(t => t.fecha.Equals(fecha_inicio1)).ToList();
                        var venta = Ventas.Where(t => t.fecha.Equals(fecha_inicio1)).ToList();
                        var tarjeta = ventasTarjeta.Where(t => t.fecha.Equals(fecha_inicio1)).ToList();
                        var ventasSericios = Ventas.Where(t => t.fecha.Equals(fecha_inicio1) && t.categoria.Equals("Servicios")).ToList();
                        var ventasProductos = Ventas.Where(t => t.fecha.Equals(fecha_inicio1) && t.categoria != "Servicios").ToList();
                        Font f5 = new Font("Arial", 9, FontStyle.Bold);
                        Font f6 = new Font("Arial", 7, FontStyle.Regular);
                        e.Graphics.DrawString(String.Format("Beauty Life Studio "), f5, Brushes.Black, 5, 10);
                        e.Graphics.DrawString(String.Format("Carretera mezquital #504"), f5, Brushes.Black, 5, 35);
                        e.Graphics.DrawString(String.Format("Prolongacion nazas, local 1 "), f5, Brushes.Black, 5, 60);
                        e.Graphics.DrawString(String.Format("Corte del dia"), f5, Brushes.Black, 40, 85);
                        e.Graphics.DrawString(String.Format(fecha_inicio1), f5, Brushes.Black, 40, 110);
                        e.Graphics.DrawString(String.Format("---Entradas efectivo---"), f6, Brushes.Black, 10, 135);
                        e.Graphics.DrawString(String.Format("Inicio caja: "), f6, Brushes.Black, 10, 160);
                        if (inicio.Count != 0)
                        {
                            e.Graphics.DrawString(String.Format(inicio[0].ingresoInicial), f6, Brushes.Black, 70, 160);
                        }
                        else
                        {
                            e.Graphics.DrawString(String.Format("$0.00"), f6, Brushes.Black, 70, 160);
                        }
                        if(entrada.Count != 0)
                        {
                            entrada.ForEach(item => {
                                e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", item.ingreso), f6, Brushes.Black, 10, pasi1);
                                e.Graphics.DrawString(item.motivo.ToString(), f6, Brushes.Black, 50, pasi1);
                                pasi1 += 25;
                            });
                        }
                        e.Graphics.DrawString(String.Format("---Salidas de efectivo---"), f6, Brushes.Black, 40, pasi1);
                        pasi1 += 25;
                        if (salida.Count != 0)
                        {
                            salida.ForEach(item => {
                                e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", item.salida), f6, Brushes.Black, 10, pasi1);
                                e.Graphics.DrawString(item.motivo.ToString(), f6, Brushes.Black, 50, pasi1);
                                pasi1 += 25;
                            });
                        }
                        e.Graphics.DrawString(String.Format("---Ventas de contado---"), f6, Brushes.Black, 40, pasi1);
                        pasi1 += 25;
                        e.Graphics.DrawString(String.Format("Efectivo: "), f6, Brushes.Black, 10, pasi1);
                        if (venta.Count > 0)
                        {
                            venta.ForEach(item => {
                                importe += Convert.ToDecimal(item.importe.Replace("$", ""));
                            });
                            e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", importe), f6, Brushes.Black, 50, pasi1);
                            pasi1 += 25;
                        }
                        else
                        {
                            e.Graphics.DrawString(String.Format("$0.00"), f6, Brushes.Black, 50, pasi1);
                            pasi1 += 25;
                        }
                        e.Graphics.DrawString(String.Format("---Ventas con tarjeta---"), f6, Brushes.Black, 40, pasi1);
                        pasi1 += 25;
                        e.Graphics.DrawString(String.Format("---Total: "), f6, Brushes.Black, 10, pasi1);
                        if (tarjeta.Count != 0)
                        {
                            decimal importe2 = 0;
                            tarjeta.ForEach(item => {
                                importe2 += Convert.ToDecimal(item.importe.Replace("$", ""));
                            });
                            e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", importe2), f6, Brushes.Black, 50, pasi1);
                            pasi1 += 25;
                        }
                        e.Graphics.DrawString(String.Format("---Ventas de servicios---"), f6, Brushes.Black, 40, pasi1);
                        pasi1 += 25;
                        e.Graphics.DrawString(String.Format("---Total: "), f6, Brushes.Black, 10, pasi1);
                        if (ventasSericios.Count != 0)
                        {
                            decimal importe3 = 0;
                            ventasSericios.ForEach(item => {
                                importe3 += Convert.ToDecimal(item.importe.Replace("$", ""));
                            });
                            e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", importe3), f6, Brushes.Black, 50, pasi1);
                            pasi1 += 25;
                        }
                        e.Graphics.DrawString(String.Format("---Ventas de productos---"), f6, Brushes.Black, 40, pasi1);
                        pasi1 += 25;
                        e.Graphics.DrawString(String.Format("---Total: "), f6, Brushes.Black, 10, pasi1);
                        if (ventasProductos.Count != 0)
                        {
                            decimal importe4 = 0;
                            ventasProductos.ForEach(item => {
                                importe4 += Convert.ToDecimal(item.importe.Replace("$", ""));
                            });
                            e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", importe4), f6, Brushes.Black, 50, pasi1);
                            pasi1 += 25;
                        }
                        break;

                    /*case "ticket":
                        var ventasTicket = Ventas.Where(v => v.NumeroTicket.Equals(idUsuario)).ToList();
                        Decimal importes = 0;
                        Font f7 = new Font("Arial", 9, FontStyle.Bold);
                        Font f8 = new Font("Arial", 7, FontStyle.Regular);
                        int pos2 = 135;
                        e.Graphics.DrawString(String.Format("Abarrotera insurgentes "), f7, Brushes.Black, 5, 10);
                        e.Graphics.DrawString(String.Format("Calle geronimo hernandez #400"), f7, Brushes.Black, 5, 35);
                        e.Graphics.DrawString(String.Format("Col. insurgentes C.P. 34130 "), f7, Brushes.Black, 5, 60);
                        e.Graphics.DrawString(String.Format("Numero de ticket: " + caja), f7, Brushes.Black, 5, 85);
                        e.Graphics.DrawString(String.Format("Producto"), f7, Brushes.Black, 10, 110);
                        e.Graphics.DrawString(String.Format("Cantidad"), f7, Brushes.Black, 90, 110);
                        e.Graphics.DrawString(String.Format("Precio"), f7, Brushes.Black, 150, 110);
                        if (ventasTicket.Count != 0)
                        {
                            ventasTicket.ForEach(item => {
                                importes += Convert.ToDecimal(item.Importe.Replace("$", ""));
                                e.Graphics.DrawString(item.Descripcion, f8, Brushes.Black, 10, pos2);
                                e.Graphics.DrawString(item.Cantidad.ToString(), f8, Brushes.Black, 90, pos2);
                                e.Graphics.DrawString(item.Importe.ToString(), f8, Brushes.Black, 150, pos2);
                                pos2 += 25;
                            });
                            e.Graphics.DrawString("Total: ", f8, Brushes.Green, 25, pos2);
                            e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", importes), f8, Brushes.Black, 100, pos2);
                            pos2 += 25;
                        }
                        break;
                        */
                    case "Imprimir":
                        Font f9 = new Font("Arial", 9, FontStyle.Bold);
                        e.Graphics.DrawString(String.Format(" "), f9, Brushes.Black, 5, 10);
                        e.Graphics.DrawString(String.Format(" "), f9, Brushes.Black, 5, 35);
                        e.Graphics.DrawString(String.Format(" "), f9, Brushes.Black, 5, 60);
                        break;

                    case "venta_sin_ticket":
                        string hora2 = DateTime.Now.ToString("hh:mm:ss");
                        var ultimoTicket1 = Ventas.OrderByDescending(v => v.numeroTicket).ToList();
                        int ultimo1 = ultimoTicket1[0].numeroTicket;
                        Ventas.Where(v => v.numeroTicket.Equals(ultimo1)).Set(v => v.hora, hora2).Update();
                        tempoVentas.Where(p => p.venta.Equals(numeroVenta)).Delete();
                        Font f10 = new Font("Arial", 9, FontStyle.Bold);
                        e.Graphics.DrawString(String.Format(" "), f10, Brushes.Black, 5, 10);
                        e.Graphics.DrawString(String.Format(" "), f10, Brushes.Black, 5, 35);
                        e.Graphics.DrawString(String.Format(" "), f10, Brushes.Black, 5, 60);
                        break;
                }

            }
        }
    }
}

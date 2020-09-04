﻿using LinqToDB;
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
                        e.Graphics.DrawString(String.Format("Calle geronimo hernandez #400"), f1, Brushes.Black, 5, 35);
                        e.Graphics.DrawString(String.Format("Col. insurgentes C.P. 34130 "), f1, Brushes.Black, 5, 60);
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

                    case "corteusuario":
                        int cant = 0, pasi = 285;
                        var id_usuario = usuarios.Where(u => u.usuario.Equals(usuario)).ToList();
                        var fecha_inicio = dateTimePicker.Value.Date.ToString("dd/MMM/yyy");
                        Decimal ganancia = 0, total = 0, totalsalidas = 0, totalcaja = 0, cost = 0;
                        importe = 0;
                        var inicio = ingresos.Where(en => en.fecha.Equals(fecha_inicio)).ToList();
                        Font f3 = new Font("Arial", 9, FontStyle.Bold);
                        Font f4 = new Font("Arial", 7, FontStyle.Regular);
                        e.Graphics.DrawString(String.Format("Expendio insurgentes "), f3, Brushes.Black, 5, 10);
                        e.Graphics.DrawString(String.Format("Calle geronimo hernandez #400"), f3, Brushes.Black, 5, 35);
                        e.Graphics.DrawString(String.Format("Col. insurgentes C.P. 34130 "), f3, Brushes.Black, 5, 60);
                        e.Graphics.DrawString(String.Format("Corte diario"), f3, Brushes.Black, 40, 85);
                        e.Graphics.DrawString(String.Format(fecha_inicio), f3, Brushes.Black, 40, 110);
                        e.Graphics.DrawString(String.Format("Cajero: "), f3, Brushes.Black, 10, 135);
                        e.Graphics.DrawString(String.Format(usuario), f3, Brushes.Black, 50, 135);
                        e.Graphics.DrawString(String.Format("---Entradas efectivo---"), f4, Brushes.Black, 40, 160);
                        e.Graphics.DrawString(String.Format("Inicio caja: "), f4, Brushes.Black, 10, 185);
                        if (inicio.Count != 0)
                        {
                            e.Graphics.DrawString(String.Format(inicio[0].ingresoInicial), f4, Brushes.Black, 60, 185);
                        }
                        else
                        {
                            e.Graphics.DrawString(String.Format("$0.00"), f4, Brushes.Black, 60, 185);
                        }
                        e.Graphics.DrawString(String.Format("---Ventas de contado---"), f4, Brushes.Black, 40, 210);
                        e.Graphics.DrawString(String.Format("Efectivo: "), f4, Brushes.Black, 10, 235);
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
                            e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", importe), f4, Brushes.Black, 50, 235);
                        }
                        else
                        {
                            e.Graphics.DrawString(String.Format("$0.00"), f4, Brushes.Black, 50, 235);
                        }
                        e.Graphics.DrawString(String.Format("---Salidas---"), f4, Brushes.Black, 40, 260);
                        /*var salidas = salidasdinero.Where(s => s.Fecha.Equals(fecha_inicio) && s.IdUsuario.Equals(id_usuario[0].IdUsuario)).ToList();
                        if (salidas.Count != 0)
                        {
                            salidas.ForEach(item =>
                            {
                                e.Graphics.DrawString(item.Monto, f4, Brushes.Black, 10, pasi);
                                e.Graphics.DrawString(item.Motivo.ToString(), f4, Brushes.Black, 50, pasi);
                                pasi += 25;

                                totalsalidas += Convert.ToDecimal(item.Monto.Replace("$", ""));
                            });
                            e.Graphics.DrawString(String.Format("Total: "), f4, Brushes.Black, 10, pasi);
                            e.Graphics.DrawString(String.Format(totalsalidas.ToString()), f4, Brushes.Black, 70, pasi);
                            pasi += 25;
                        }
                        totalcaja = importe - totalsalidas;
                        var abono2 = abonos.Where(a => a.Usuario.Equals(usuario) && a.Fecha.Equals(fecha_inicio)).ToList();
                        e.Graphics.DrawString(String.Format("---Dinero en caja---"), f4, Brushes.Black, 40, pasi);
                        pasi += 25;
                        e.Graphics.DrawString(String.Format("Efectivo: "), f4, Brushes.Black, 10, pasi);
                        if (abono2.Count != 0)
                        {
                            e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", totalcaja + Convert.ToDecimal(abono2[0].Importe)), f4, Brushes.Black, 50, pasi);
                        }
                        else
                        {
                            e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", totalcaja), f4, Brushes.Black, 50, pasi);
                        }
                        pasi += 25;
                        e.Graphics.DrawString(String.Format("---Ganancia del dia---"), f4, Brushes.Black, 40, pasi);
                        pasi += 25;
                        e.Graphics.DrawString(String.Format("Total: "), f4, Brushes.Black, 10, pasi);
                        e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", ganancia), f4, Brushes.Black, 50, pasi);
                        pasi += 25;

                        e.Graphics.DrawString(String.Format("---Pagos de creditos---"), f4, Brushes.Black, 40, pasi);
                        pasi += 25;
                        e.Graphics.DrawString(String.Format("Efectivo: "), f4, Brushes.Black, 10, pasi);
                        if (abono2.Count != 0)
                        {
                            e.Graphics.DrawString(String.Format("$" + abono2[0].Importe), f4, Brushes.Black, 50, pasi);
                        }
                        else
                        {
                            e.Graphics.DrawString(String.Format("$0.00"), f4, Brushes.Black, 50, pasi);
                        }*/

                        break;

                    /*case "cortediario":
                        int cant1 = 0, pasi1 = 285;
                        var fecha_inicio1 = dateTimePicker.Value.Date.ToString("dd/MMM/yyy");
                        Decimal ganancia1 = 0, totalsalidas1 = 0, totalcaja1 = 0, cost1 = 0, costoTotal1 = 0;
                        importe = 0;
                        var inicio1 = entradasIniciales.Where(en => en.Fecha.Equals(fecha_inicio1)).ToList();
                        Font f5 = new Font("Arial", 9, FontStyle.Bold);
                        Font f6 = new Font("Arial", 7, FontStyle.Regular);
                        e.Graphics.DrawString(String.Format("Expendio insurgentes "), f5, Brushes.Black, 5, 10);
                        e.Graphics.DrawString(String.Format("Calle geronimo hernandez #400"), f5, Brushes.Black, 5, 35);
                        e.Graphics.DrawString(String.Format("Col. insurgentes C.P. 34130 "), f5, Brushes.Black, 5, 60);
                        e.Graphics.DrawString(String.Format("Corte diario"), f5, Brushes.Black, 40, 85);
                        e.Graphics.DrawString(String.Format(fecha_inicio1), f5, Brushes.Black, 40, 110);
                        e.Graphics.DrawString(String.Format("Cajero: "), f6, Brushes.Black, 10, 135);
                        e.Graphics.DrawString(String.Format("Todos"), f6, Brushes.Black, 50, 135);
                        e.Graphics.DrawString(String.Format("---Entradas efectivo---"), f6, Brushes.Black, 40, 160);
                        e.Graphics.DrawString(String.Format("Inicio caja: "), f6, Brushes.Black, 10, 185);
                        if (inicio1.Count != 0)
                        {
                            e.Graphics.DrawString(String.Format(inicio1[0].Ingreso), f6, Brushes.Black, 60, 185);
                        }
                        else
                        {
                            e.Graphics.DrawString(String.Format("$0.00"), f6, Brushes.Black, 60, 185);
                        }
                        e.Graphics.DrawString(String.Format("---Ventas de contado---"), f6, Brushes.Black, 40, 210);
                        e.Graphics.DrawString(String.Format("Efectivo: "), f6, Brushes.Black, 10, 235);
                        var venta1 = Ventas.Where(t => t.Fecha.Equals(fecha_inicio1)).ToList();
                        if (venta1.Count > 0)
                        {
                            venta1.ForEach(item => {
                                importe += Convert.ToDecimal(item.Importe.Replace("$", ""));
                                cant1 += item.Cantidad;
                                cost1 += Convert.ToDecimal(item.Costo);
                            });
                            costoTotal1 = cant1 * cost1;
                            ganancia = importe - costoTotal1;
                            e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", importe), f6, Brushes.Black, 50, 235);
                        }
                        else
                        {
                            e.Graphics.DrawString(String.Format("$0.00"), f6, Brushes.Black, 50, 235);
                        }
                        e.Graphics.DrawString(String.Format("---Salidas---"), f6, Brushes.Black, 40, 260);
                        var salidas1 = salidasdinero.Where(s => s.Fecha.Equals(fecha_inicio1)).ToList();
                        if (salidas1.Count != 0)
                        {
                            salidas1.ForEach(item =>
                            {
                                e.Graphics.DrawString(item.Monto, f6, Brushes.Black, 10, pasi1);
                                e.Graphics.DrawString(item.Motivo.ToString(), f6, Brushes.Black, 50, pasi1);
                                pasi1 += 25;

                                totalsalidas1 += Convert.ToDecimal(item.Monto.Replace("$", ""));
                            });
                            e.Graphics.DrawString(String.Format("Total: "), f6, Brushes.Black, 10, pasi1);
                            e.Graphics.DrawString(String.Format(totalsalidas1.ToString()), f6, Brushes.Black, 70, pasi1);
                            pasi1 += 25;
                        }
                        totalcaja1 = importe - totalsalidas1;
                        var abono1 = abonos.Where(a => a.Fecha.Equals(fecha_inicio1)).ToList();
                        e.Graphics.DrawString(String.Format("---Dinero en caja---"), f6, Brushes.Black, 40, pasi1);
                        pasi1 += 25;
                        e.Graphics.DrawString(String.Format("Efectivo: "), f6, Brushes.Black, 10, pasi1);
                        if (abono1.Count != 0)
                        {
                            e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", totalcaja1 + Convert.ToDecimal(abono1[0].Importe)), f6, Brushes.Black, 50, pasi1);
                        }
                        else
                        {
                            e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", totalcaja1), f6, Brushes.Black, 50, pasi1);
                        }

                        pasi1 += 25;
                        e.Graphics.DrawString(String.Format("---Ganancia del dia---"), f6, Brushes.Black, 40, pasi1);
                        pasi1 += 25;
                        e.Graphics.DrawString(String.Format("Total: "), f6, Brushes.Black, 10, pasi1);
                        e.Graphics.DrawString(string.Format("${0:#,###,###,##0.00####}", ganancia1), f6, Brushes.Black, 50, pasi1);
                        pasi1 += 25;

                        e.Graphics.DrawString(String.Format("---Pagos de creditos---"), f6, Brushes.Black, 40, pasi1);
                        pasi1 += 25;
                        e.Graphics.DrawString(String.Format("Efectivo: "), f6, Brushes.Black, 10, pasi1);
                        if (abono1.Count != 0)
                        {
                            e.Graphics.DrawString(String.Format("$" + abono1[0].Importe), f6, Brushes.Black, 50, pasi1);
                        }
                        else
                        {
                            e.Graphics.DrawString(String.Format("$0.00"), f6, Brushes.Black, 50, pasi1);
                        }
                        break;

                    case "ticket":
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

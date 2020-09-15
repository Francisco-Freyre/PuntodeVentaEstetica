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
        private Decimal importe = 0, totalPagar = 0m;
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

        public void borrarVenta(string codigo, int cant, int venta)
        {
            int cantidad = 0, existencia = 0;
            var ventatemp = tempoVentas.Where(t => t.codigo.Equals(codigo) && t.venta.Equals(venta)).ToList();
            cantidad = ventatemp[0].cantidad;
            var producto = productos.Where(p => p.codigo.Equals(codigo)).ToList();
            existencia = producto[0].existencia;

            if (cant == 1)
            {
                existencia += cantidad;
                tempoVentas.Where(t => t.idTempo == ventatemp[0].idTempo && t.venta.Equals(venta)).Delete();
            }
            else
            {
                existencia++;
                guardarVentasTempo(codigo, 1, venta);
            }
            productos.Where(p => p.idProducto.Equals(producto[0].idProducto))
                        .Set(t => t.existencia, existencia)
                        .Update();
        }

        public void cobrar(CheckBox checkBoxHistorial, CheckBox checkBoxTarjeta , TextBox textBox_pagos, Label label, int venta, int idCliente)
        {
            var ultimoTicket = Ventas.OrderByDescending(v => v.numeroTicket).ToList();
            int ultimo = ultimoTicket[0].numeroTicket;
            if (textBox_pagos.Text == "")
            {
                label.Text = "Ingrese el pago";
                label.ForeColor = Color.Red;
                textBox_pagos.Focus();
            }
            else
            {
                String saldoActual, IDCliente = null;
                Decimal pagos=0, ingresosInicial;
                //pagos = Convert.ToDecimal(textBox_pagos.Text);
                if (checkBoxHistorial.Checked == false && checkBoxTarjeta.Checked == false)
                {
                    var ventaTempo = tempoVentas.Where(t => t.venta.Equals(venta)).ToList();
                    var ing = ingresos.Where(i => i.fecha.Equals(fecha)).ToList();
                    ultimo++;
                    if (ventaTempo.Count > 0)
                    {
                        ventaTempo.ForEach(item =>
                        {
                            Ventas.Value(v => v.numeroTicket, ultimo)
                                    .Value(v => v.codigo, item.codigo)
                                    .Value(v => v.descripcion, item.descripcion)
                                    .Value(v => v.precio, item.precio)
                                    .Value(v => v.cantidad, item.cantidad)
                                    .Value(v => v.importe, item.importe)
                                    .Value(v => v.costo, item.costo)
                                    .Value(v => v.categoria, item.categoria)
                                    .Value(v => v.fecha, fecha)
                                    .Value(v => v.hora, DateTime.Now.ToString("hh:mm:ss"))
                                    .Insert();
                            pagos += Convert.ToDecimal(item.importe.Replace("$",""));
                        });
                        pagos += Convert.ToDecimal(ing[0].ingreso.Replace("$",""));
                        ingresos.Where(i => i.fecha.Equals(fecha))
                                .Set(i => i.ingreso, String.Format("${0:#,###,###,##0.00####}", pagos))
                                .Update();
                    }
                }
                else
                {
                    if (checkBoxHistorial.Checked == true && checkBoxTarjeta.Checked == true)
                    {
                        var ventaTempo = tempoVentas.Where(t => t.venta.Equals(venta)).ToList();
                        ultimo++;
                        if (ventaTempo.Count > 0)
                        {
                            ventaTempo.ForEach(item =>
                            {
                                ventasTarjeta.Value(v => v.numeroTicket, ultimo)
                                        .Value(v => v.codigo, item.codigo)
                                        .Value(v => v.descripcion, item.descripcion)
                                        .Value(v => v.precio, item.precio)
                                        .Value(v => v.cantidad, item.cantidad)
                                        .Value(v => v.importe, item.importe)
                                        .Value(v => v.costo, item.costo)
                                        .Value(v => v.categoria, item.categoria)
                                        .Value(v => v.fecha, fecha)
                                        .Value(v => v.hora, DateTime.Now.ToString("hh:mm:ss"))
                                        .Insert();
                                ventasClientes.Value(v => v.idCliente, idCliente)
                                                .Value(v => v.codigo, item.codigo)
                                                .Value(v => v.descripcion, item.descripcion)
                                                .Value(v => v.precio, item.precio)
                                                .Value(v => v.cantidad, item.cantidad)
                                                .Value(v => v.importe, item.importe)
                                                .Value(v => v.costo, item.costo)
                                                .Value(v => v.categoria, item.categoria)
                                                .Value(v => v.fecha, fecha)
                                                .Value(v => v.hora, DateTime.Now.ToString("hh:mm:ss"))
                                                .Insert();
                            });
                        }
                    }
                    else
                    {
                        if (checkBoxHistorial.Checked)
                        {
                            var ventaTempo = tempoVentas.Where(t => t.venta.Equals(venta)).ToList();
                            var ing = ingresos.Where(i => i.fecha.Equals(fecha)).ToList();
                            ultimo++;
                            if (ventaTempo.Count > 0)
                            {
                                ventaTempo.ForEach(item =>
                                {
                                    Ventas.Value(v => v.numeroTicket, ultimo)
                                            .Value(v => v.codigo, item.codigo)
                                            .Value(v => v.descripcion, item.descripcion)
                                            .Value(v => v.precio, item.precio)
                                            .Value(v => v.cantidad, item.cantidad)
                                            .Value(v => v.importe, item.importe)
                                            .Value(v => v.costo, item.costo)
                                            .Value(v => v.categoria, item.categoria)
                                            .Value(v => v.fecha, fecha)
                                            .Value(v => v.hora, DateTime.Now.ToString("hh:mm:ss"))
                                            .Insert();
                                    ventasClientes.Value(v => v.idCliente, idCliente)
                                                    .Value(v => v.codigo, item.codigo)
                                                    .Value(v => v.descripcion, item.descripcion)
                                                    .Value(v => v.precio, item.precio)
                                                    .Value(v => v.cantidad, item.cantidad)
                                                    .Value(v => v.importe, item.importe)
                                                    .Value(v => v.costo, item.costo)
                                                    .Value(v => v.categoria, item.categoria)
                                                    .Value(v => v.fecha, fecha)
                                                    .Value(v => v.hora, DateTime.Now.ToString("hh:mm:ss"))
                                                    .Insert();
                                    pagos += Convert.ToDecimal(item.importe.Replace("$", ""));
                                });

                                pagos += Convert.ToDecimal(ing[0].ingreso.Replace("$", ""));
                                ingresos.Where(i => i.fecha.Equals(fecha))
                                        .Set(i => i.ingreso, String.Format("${0:#,###,###,##0.00####}", pagos))
                                        .Update();
                            }
                        }
                        else
                        {
                            if (checkBoxTarjeta.Checked)
                            {
                                var ventaTempo = tempoVentas.Where(t => t.venta.Equals(venta)).ToList();
                                ultimo++;
                                if (ventaTempo.Count > 0)
                                {
                                    ventaTempo.ForEach(item =>
                                    {
                                        ventasTarjeta.Value(v => v.numeroTicket, ultimo)
                                                .Value(v => v.codigo, item.codigo)
                                                .Value(v => v.descripcion, item.descripcion)
                                                .Value(v => v.precio, item.precio)
                                                .Value(v => v.cantidad, item.cantidad)
                                                .Value(v => v.importe, item.importe)
                                                .Value(v => v.costo, item.costo)
                                                .Value(v => v.categoria, item.categoria)
                                                .Value(v => v.fecha, fecha)
                                                .Value(v => v.hora, DateTime.Now.ToString("hh:mm:ss"))
                                                .Insert();
                                    });
                                }
                            }
                        }
                    }
                }

            }
        }

        public bool pagosCliente(TextBox textBox, Label label1, Label label2, Label label3, Label label4)
        {
            bool valor = false;
            Decimal pago, pagar;
            if (textBox.Text == "")
            {
                label1.Text = "Su cambio";
                label2.Text = "$0.00";
                valor = false;
            }
            else
            {
                importe = Convert.ToDecimal(label4.Text.Replace("$", ""));
                var ingresosIni = ingresos.Where(i => i.fecha.Equals(fecha)).ToList();
                decimal ingresostotales = Convert.ToDecimal(ingresosIni[0].ingresoInicial.Replace("$", "")) + Convert.ToDecimal(ingresosIni[0].ingreso.Replace("$", ""));
                pagar = importe;
                pago = Convert.ToDecimal(textBox.Text);
                if (pago >= pagar)
                {
                    totalPagar = pago - pagar;
                    if (totalPagar > ingresostotales)
                    {
                        label1.Text = "No hay ingresos en caja";
                        label1.ForeColor = Color.Red;
                        valor = false;
                    }
                    else
                    {
                        label1.Text = "Su cambio";
                        label1.ForeColor = Color.Green;
                        totalPagar = pago - pagar;
                        valor = true;
                    }
                }
                if (pago < pagar)
                {
                    label1.Text = "Pago insuficiente";
                    label1.ForeColor = Color.Red;
                    totalPagar = pagar - pago;
                    valor = false;
                }
                label2.Text = String.Format("${0:#,###,###,##0.00####}", totalPagar);
            }
            label3.Text = "Pago con";
            label3.ForeColor = Color.Teal;
            return valor;
        }
    }
}

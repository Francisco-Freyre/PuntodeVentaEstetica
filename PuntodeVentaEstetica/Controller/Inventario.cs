using LinqToDB;
using PuntodeVentaEstetica.Connection;
using PuntodeVentaEstetica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVentaEstetica.Controller
{
    class Inventario : Conexion
    {
        public void getProducto(string campo, CheckBox checkBoxBdga_Agotados, Label label, Label label2, DataGridView dataGridView1)
        {
            IEnumerable<productos> query;
            decimal costo = 0, costo1 = 0, precioventa = 0, precioventa1 = 0;
            if (campo == "")
            {
                if (checkBoxBdga_Agotados.Checked == false)
                {
                    query = productos.ToList();

                    var coso = productos.ToList();

                    coso.ForEach(item =>
                    {
                        costo = item.costo * item.existencia;
                        precioventa = item.precioVenta * item.existencia;
                        costo1 += costo;
                        precioventa1 += precioventa;
                    });
                    label.Text = "$" + Convert.ToString(costo1);
                    label2.Text = "$" + Convert.ToString(precioventa1 - costo1);
                }
                else
                {
                    query = productos.Where(p => p.existencia <= p.minimo).ToList();

                    var coso = productos.Where(p => p.existencia <= p.minimo).ToList();

                    coso.ForEach(item =>
                    {
                        costo = item.costo * item.existencia;
                        precioventa = item.precioVenta * item.existencia;
                        costo1 += costo;
                        precioventa1 += precioventa;
                    });
                    label.Text = "$" + Convert.ToString(costo1);
                    label2.Text = "$" + Convert.ToString(precioventa1 - costo1);
                }

            }
            else
            {
                if (checkBoxBdga_Agotados.Checked == false)
                {
                    query = productos.Where(p => p.categoria.Contains(campo) ||
                    p.codigo.Contains(campo) || p.descripcion.Contains(campo)).ToList();

                    var coso = productos.Where(p => p.categoria.Contains(campo) ||
                    p.codigo.Contains(campo) || p.descripcion.Contains(campo)).ToList();

                    coso.ForEach(item =>
                    {
                        costo = item.costo * item.existencia;
                        precioventa = item.precioVenta * item.existencia;
                        costo1 += costo;
                        precioventa1 += precioventa;
                    });
                    label.Text = "$" + Convert.ToString(costo1);
                    label2.Text = "$" + Convert.ToString(precioventa1 - costo1);
                }
                else
                {
                    query = productos.Where(p => p.existencia <= p.minimo && p.codigo.Contains(campo) ||
                    p.categoria.Contains(campo) && p.existencia <= p.minimo || p.descripcion.Contains(campo) && p.existencia <= p.minimo).ToList();

                    var coso = productos.Where(p => p.existencia <= p.minimo && p.codigo.Contains(campo) ||
                    p.categoria.Contains(campo) && p.existencia <= p.minimo || p.descripcion.Contains(campo) && p.existencia <= p.minimo).ToList();

                    coso.ForEach(item =>
                    {
                        costo = item.costo * item.existencia;
                        precioventa = item.precioVenta * item.existencia;
                        costo1 += costo;
                        precioventa1 += precioventa;
                    });
                    label.Text = "$" + Convert.ToString(costo1);
                    label2.Text = "$" + Convert.ToString(precioventa1 - costo1);
                }


            }
            dataGridView1.DataSource = query.ToList();
            dataGridView1.Columns[0].Visible = false;
        }

        public void updateExistencia(string existencia, int idProd)
        {
            if (existencia != "")
            {
                productos.Where(b => b.idProducto.Equals(idProd))
                        .Set(b => b.existencia, Convert.ToInt16(existencia))
                        .Update();
            }
        }

        public int buscarVentas(string campo, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2, CheckBox checkBoxInv_MaxVentas, DataGridView dataGridView2)
        {
            List<ventas> query = new List<ventas>();
            var fecha_inicio = dateTimePicker1.Value.Date.ToString("dd/MMM/yyy");
            int valor = 0;
            if (campo == "")
            {
                if (checkBoxInv_MaxVentas.Checked == true)
                {
                    if (DateTime.Compare(dateTimePicker2.Value.Date, dateTimePicker1.Value.Date) < 0)
                    {
                        MessageBox.Show("\nLa fecha final debe ser mayor a la fecha inicial\n");
                    }
                    else
                    {
                        query = maxVentas(filtrarProductosFechas(fecha_inicio, dateTimePicker2)).Where(c => c.codigo.Contains(campo) ||
                        c.categoria.Contains(campo)).ToList();
                        valor = query.Count;
                    }
                }
                else
                {
                    if (DateTime.Compare(dateTimePicker2.Value.Date, dateTimePicker1.Value.Date) < 0)
                    {
                        MessageBox.Show("\nLa fecha final debe ser mayor a la fecha inicial\n");
                    }
                    else
                    {
                        query = filtrarProductosFechas(fecha_inicio, dateTimePicker2).Where(c => c.codigo.Contains(campo) || c.categoria.Contains(campo)).ToList();
                        valor = query.Count;
                    }
                }
            }
            else
            {
                if (checkBoxInv_MaxVentas.Checked == true)
                {
                    if (DateTime.Compare(dateTimePicker2.Value.Date, dateTimePicker1.Value.Date) < 0)
                    {
                        MessageBox.Show("\nLa fecha final debe ser mayor a la fecha inicial\n");
                    }
                    else
                    {
                        query = maxVentas(filtrarProductosFechas(fecha_inicio, dateTimePicker2)).Where(c => c.codigo.Contains(campo) || c.categoria.Contains(campo)).ToList();
                        valor = query.Count;
                    }

                }
                else
                {
                    if (DateTime.Compare(dateTimePicker2.Value.Date, dateTimePicker1.Value.Date) < 0)
                    {
                        MessageBox.Show("\nLa fecha final debe ser mayor a la fecha inicial\n");
                    }
                    else
                    {
                        query = filtrarProductosFechas(fecha_inicio, dateTimePicker2).Where(c => c.codigo.Contains(campo) || c.categoria.Contains(campo)).ToList();
                        valor = query.Count;
                    }
                }
            }
            dataGridView2.DataSource = query.ToList();
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[9].Visible = false;
            dataGridView2.Columns[10].Visible = false;
            return valor;
        }

        private List<ventas> maxVentas(IEnumerable<ventas> query)
        {
            List<ventas> listProduct = new List<ventas>();
            foreach (var item in query)
            {
                if (verificar(item))
                {
                    listProduct.Add(new ventas
                    {
                        idVenta = item.idVenta,
                        codigo = item.codigo,
                        descripcion = item.descripcion,
                        precio = item.precio,
                        cantidad = item.cantidad,
                        importe = item.importe,
                        fecha = item.fecha,
                        numeroTicket = item.numeroTicket,
                        costo = item.costo,
                        hora = item.hora,
                        categoria = item.categoria
                    });
                }
            }
            bool verificar(ventas data)
            {
                int pos = 0, cant;
                Decimal importe1, importe2, importe3;
                foreach (var item in listProduct)
                {
                    if (item.codigo.Equals(data.codigo))
                    {
                        importe1 = Convert.ToDecimal(item.importe.Replace("$", ""));
                        importe2 = Convert.ToDecimal(data.importe.Replace("$", ""));
                        importe3 = importe1 + importe2;
                        var imporetes = String.Format("${0: #,###,###,##0.00####}", importe3);
                        cant = item.cantidad + data.cantidad;
                        listProduct.RemoveAt(pos);
                        listProduct.Insert(pos, new ventas
                        {
                            idVenta = item.idVenta,
                            codigo = item.codigo,
                            descripcion = item.descripcion,
                            precio = item.precio,
                            cantidad = cant,
                            importe = imporetes.Replace(" ", ""),
                            fecha = item.fecha,
                            numeroTicket = item.numeroTicket,
                            costo = item.costo,
                            hora = item.hora,
                            categoria = item.categoria
                        });
                        return false;
                    }
                    pos++;
                    cant = 0;
                }
                return true;
            }
            return listProduct.OrderBy(p => p.cantidad).Reverse().ToList();
        }

        private List<ventas> filtrarProductosFechas(string fecha_inicio, DateTimePicker dateTimePicker2)
        {
            List<ventas> listProduct = new List<ventas>();
            var listdb1 = Ventas.Where(c => c.fecha.Equals(fecha_inicio)).ToList();
            if (0 < listdb1.Count)
            {
                var listdb2 = Ventas.Where(c => c.idVenta >= listdb1[0].idVenta).ToList();
                foreach (var item in listdb2)
                {
                    if (DateTime.Compare(dateTimePicker2.Value.Date, DateTime.Parse(item.fecha)) > 0 ||
                        DateTime.Compare(dateTimePicker2.Value.Date, DateTime.Parse(item.fecha)) == 0)
                    {
                        listProduct.Add(new ventas
                        {
                            idVenta = item.idVenta,
                            codigo = item.codigo,
                            descripcion = item.descripcion,
                            precio = item.precio,
                            cantidad = item.cantidad,
                            importe = item.importe,
                            fecha = item.fecha,
                            numeroTicket = item.numeroTicket,
                            costo = item.costo,
                            hora = item.hora,
                            categoria = item.categoria
                        });
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return listProduct;
        }
    }
}
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
    class Ingreso : Conexion
    {
        public void insetarIngresoInicial(string dinero)
        {
            var ingresosIniciales = ingresos.Where(t => t.fecha.Equals(DateTime.Now.ToString("dd/MMM/yyy"))).ToList();

            if(ingresosIniciales.Count <= 0)
            {
                ingresos.Value(t => t.ingresoInicial, dinero)
                        .Value(t => t.ingreso, "$0.00")
                        .Value(t => t.fecha, DateTime.Now.ToString("dd/MMM/yyy"))
                        .Insert();
            }
        }

        public void insetarEntrada(string dinero, string motivo)
        {
            var ingresosIniciales = ingresos.Where(t => t.fecha.Equals(DateTime.Now.ToString("dd/MMM/yyy"))).ToList();

            if (dinero != "" && motivo != "")
            {
                entradas.Value(t => t.ingreso, dinero)
                        .Value(t => t.motivo, motivo)
                        .Value(t => t.fecha, DateTime.Now.ToString("dd/MMM/yyy"))
                        .Insert();

                ingresos.Where(t => t.fecha.Equals(DateTime.Now.ToString("dd/MMM/yyy")))
                        .Set(t => t.ingreso, Convert.ToString(Convert.ToDecimal(ingresosIniciales[0].ingreso.Replace("$","")) + Convert.ToDecimal(dinero.Replace("$", ""))))
                        .Update();
            }
            
        }

        public void insetarSalida(string dinero, string motivo)
        {
            var ingresosIniciales = ingresos.Where(t => t.fecha.Equals(DateTime.Now.ToString("dd/MMM/yyy"))).ToList();

            if (dinero != "" && motivo != "")
            {
                if ((Convert.ToDecimal(ingresosIniciales[0].ingresoInicial.Replace("$", "")) + Convert.ToDecimal(ingresosIniciales[0].ingreso.Replace("$",""))) >= Convert.ToDecimal(dinero.Replace("$", "")))
                {
                    salidas.Value(t => t.salida, dinero)
                        .Value(t => t.motivo, motivo)
                        .Value(t => t.fecha, DateTime.Now.ToString("dd/MMM/yyy"))
                        .Insert();

                    ingresos.Where(t => t.fecha.Equals(DateTime.Now.ToString("dd/MMM/yyy")))
                            .Set(t => t.ingreso, Convert.ToString(Convert.ToDecimal(ingresosIniciales[0].ingreso.Replace("$", "")) - Convert.ToDecimal(dinero.Replace("$", ""))))
                            .Update();
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada es mayor a la que hay de ingresos totales", "Punto Venta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}

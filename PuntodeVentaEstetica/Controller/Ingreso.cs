using LinqToDB;
using PuntodeVentaEstetica.Connection;
using PuntodeVentaEstetica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}

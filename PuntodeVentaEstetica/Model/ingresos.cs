using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVentaEstetica.Model
{
    class ingresos
    {
        [PrimaryKey, Identity]

        public int id { set; get; }

        public string ingresoInicial { set; get; }

        public string ingreso { set; get; }

        public string fecha { set; get; }
    }
}

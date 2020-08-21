using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVentaEstetica.Model
{
    class ventasTarjeta
    {
        [PrimaryKey, Identity]

        public int idVenta { set; get; }

        public int numeroTicket { set; get; }

        public string codigo { set; get; }

        public string descripcion { set; get; }

        public string precio { set; get; }

        public int cantidad { set; get; }

        public string importe { set; get; }

        public string costo { set; get; }

        public string categoria { set; get; }

        public string fecha { set; get; }

        public string hora { set; get; }
    }
}

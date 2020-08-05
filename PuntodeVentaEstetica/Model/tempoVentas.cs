using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVentaEstetica.Model
{
    class tempoVentas
    {
        [PrimaryKey, Identity]

        public int idTempo { set; get; }

        public string codigo { set; get; }

        public string descripcion { set; get; }

        public string precio { set; get; }

        public int cantidad { set; get; }

        public string importe { set; get; }

        public string costo { set; get; }

        public string categoria { set; get; }

        public int venta { set; get; }
    }
}

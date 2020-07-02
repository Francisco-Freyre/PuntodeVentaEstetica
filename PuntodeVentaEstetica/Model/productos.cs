    using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVentaEstetica.Model
{
    class productos
    {
        [PrimaryKey, Identity]

        public int idProducto { set; get; }

        public string codigo { set; get; }

        public string descripcion { set; get; }

        public decimal costo { set; get; }

        public decimal precioVenta { set; get; }

        public int existencia { set; get; }

        public int minimo { set; get; }

        public string categoria { set; get; }
    }
}

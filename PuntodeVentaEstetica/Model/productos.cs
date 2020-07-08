    using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVentaEstetica.Model
{
    class productos
    {
        [PrimaryKey, Identity]

        public int idProducto { set; get; }

        [DisplayName("Codigo de barras")]
        public string codigo { set; get; }

        [DisplayName("Descripcion")]
        public string descripcion { set; get; }

        [DisplayName("Costo")]
        public decimal costo { set; get; }

        [DisplayName("Precio de venta")]
        public decimal precioVenta { set; get; }

        [DisplayName("Existencia")]
        public int existencia { set; get; }

        [DisplayName("Minimo")]
        public int minimo { set; get; }

        [DisplayName("Categoria")]
        public string categoria { set; get; }
    }
}

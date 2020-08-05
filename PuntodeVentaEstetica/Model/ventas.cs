using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVentaEstetica.Model
{
    class ventas
    {
        [PrimaryKey, Identity]

        public int IdVenta { set; get; }

        public string Codigo { set; get; }

        public string Descripcion { set; get; }

        public string Precio { set; get; }

        public int Cantidad { set; get; }

        public string Importe { set; get; }

        public string Fecha { set; get; }

        public int IdUsuario { set; get; }

        public int NumeroTicket { set; get; }

        public string Costo { set; get; }

        public string Hora { set; get; }

        public string Categoria { set; get; }
    }
}

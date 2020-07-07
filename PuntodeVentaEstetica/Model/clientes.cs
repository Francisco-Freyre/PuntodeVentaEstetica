using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVentaEstetica.Model
{
    class clientes
    {
        [PrimaryKey, Identity]

        public int idCliente { set; get; }

        public string nombre { set; get; }

        public string apellido { set; get; }

        public string telefono { set; get; }

        public string direccion { set; get; }

        public string correo { set; get; }
    }
}

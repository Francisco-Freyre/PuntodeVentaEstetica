using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVentaEstetica.Model
{
    class clientes
    {
        [PrimaryKey, Identity]

        public int idCliente { set; get; }

        [DisplayName("Nombre")]
        public string nombre { set; get; }

        [DisplayName("Apellido")]
        public string apellido { set; get; }

        [DisplayName("Telefono")]
        public string telefono { set; get; }

        [DisplayName("Direccion")]
        public string direccion { set; get; }

        [DisplayName("Correo")]
        public string correo { set; get; }
    }
}

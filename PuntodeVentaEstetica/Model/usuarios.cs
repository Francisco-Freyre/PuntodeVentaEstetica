using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace PuntodeVentaEstetica.Model
{
    class usuarios
    {
        [PrimaryKey, Identity]

        [DisplayName("Identificador")]
        public int idUsuario { set; get; }

        [DisplayName("Nombre")]
        public string nombre { set; get; }

        [DisplayName("Apellido")]
        public string apellido { set; get; }

        [DisplayName("Usuario")]
        public string usuario { set; get; }

        public string contrasenia { set; get; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace PuntodeVentaEstetica.Model
{
    class usuarios
    {
        [PrimaryKey, Identity]

        public int idUsuario { set; get; }

        public string nombre { set; get; }

        public string apellido { set; get; }

        public string usuario { set; get; }

        public string contrasenia { set; get; }
    }
}

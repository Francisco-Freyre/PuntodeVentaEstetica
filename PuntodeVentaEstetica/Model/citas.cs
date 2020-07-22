using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVentaEstetica.Model
{
    class citas
    {
        [PrimaryKey, Identity]

        public int idCita { set; get; }

        [DisplayName("Nombre")]
        public string nombre { set; get; }

        [DisplayName("Telefono")]
        public string telefono { set; get; }

        [DisplayName("Concepto")]
        public string concepto { set; get; }

        [DisplayName("Fecha")]
        public string fecha { set; get; }

        [DisplayName("Hora")]
        public string hora { set; get; }
    }
}

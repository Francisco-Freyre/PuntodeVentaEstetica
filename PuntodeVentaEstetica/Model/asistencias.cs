using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVentaEstetica.Model
{
    class asistencias
    {
        [PrimaryKey, Identity]

        public int idAsistencia { set; get; }

        [DisplayName("Usuario")]
        public string usuario { set; get; }

        [DisplayName("Fecha")]
        public string fecha { set; get; }

        [DisplayName("Hora de entrada")]
        public string horaEntrada { set; get; }

        [DisplayName("Hora de salida")]
        public string horaSalida { set; get; }
    }
}

using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVentaEstetica.Model
{
    class salidas
    {
        [PrimaryKey, Identity]

        public int id { set; get; }

        public string salida { set; get; }

        public string motivo { set; get; }

        public string fecha { set; get; }
    }
}

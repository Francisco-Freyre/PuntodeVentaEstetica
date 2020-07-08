using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVentaEstetica.Model
{
    class categorias
    {
        [PrimaryKey, Identity]

        public int IdCat { set; get; }

        [DisplayName("Categoria")]
        public string categoria { set; get; }
    }
}

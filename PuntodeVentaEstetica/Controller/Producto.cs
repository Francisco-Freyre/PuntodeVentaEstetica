using LinqToDB;
using PuntodeVentaEstetica.Connection;
using PuntodeVentaEstetica.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVentaEstetica.Controller
{
    class Producto : Conexion
    {
        public List<categorias> GetCategorias()
        {
            return categorias.ToList();
        }

        public List<productos> GetProductos()
        {
            return productos.ToList();
        }

        public void buscarCat(DataGridView dataGridView, string campo)
        {
            IEnumerable<categorias> query;
            if (campo == "")
                query = categorias.ToList();
            else
                query = categorias.Where(d => d.categoria.StartsWith(campo));
            dataGridView.DataSource = query.ToList();
            dataGridView.Columns[0].Visible = false;
        }

        public void insertarCat(string cate)
        {
            categorias.Value(c => c.categoria, cate).Insert();
        }

        public void eliminarCat(int idCat)
        {
            categorias.Where(c => c.IdCat == idCat).Delete();
            
        }
    }
}

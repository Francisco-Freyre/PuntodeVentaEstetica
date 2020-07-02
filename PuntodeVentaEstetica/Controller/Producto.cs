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

        internal void guardarProducto(string codigo, string descripcion, decimal costo, decimal precioventa, int existencia,
            int minimo, string categoria)
        {
            var valorProducto = productos.Where(p => p.codigo == codigo).ToList();
            if (valorProducto.Count > 0)
            {
                productos.Where(p => p.idProducto == valorProducto[0].idProducto)
                         .Set(p => p.codigo, codigo)
                         .Set(p => p.descripcion, descripcion)
                         .Set(p => p.costo, costo)
                         .Set(p => p.precioVenta, precioventa)
                         .Set(p => p.existencia, existencia)
                         .Set(p => p.minimo, minimo)
                         .Set(p => p.categoria, categoria)
                         .Update();
            }
            else
            {
                productos.Value(p => p.codigo, codigo)
                         .Value(p => p.descripcion, descripcion)
                         .Value(p => p.costo, costo)
                         .Value(p => p.precioVenta, precioventa)
                         .Value(p => p.existencia, existencia)
                         .Value(p => p.minimo, minimo)
                         .Value(p => p.categoria, categoria)
                         .Insert();
            }
        }

        public void buscarProducto(DataGridView dataGridView, string campo)
        {
            IEnumerable<productos> query;
            if (campo == "")
            {
                query = productos.ToList();
            }
            else
            {
                query = productos.Where(p => p.descripcion.Contains(campo) || p.codigo.Contains(campo) ||
                p.categoria.Contains(campo));
            }
            dataGridView.DataSource = query.ToList();
            dataGridView.Columns[0].Visible = false;
        }

        internal void borrarProducto(int idProducto)
        {
            var valorProducto = productos.Where(p => p.idProducto == idProducto).ToList();
            productos.Where(p => p.idProducto == idProducto).Delete();
        }
    }
}

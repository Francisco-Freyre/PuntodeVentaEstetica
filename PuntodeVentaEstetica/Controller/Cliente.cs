using LinqToDB;
using PuntodeVentaEstetica.Connection;
using PuntodeVentaEstetica.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVentaEstetica.Controller
{
    class Cliente : Conexion
    {
        public List<clientes> getClientes()
        {
            var query = from c in clientes
                        select c;
            return query.ToList();
        }

        public void insertarCliente(string nombre, string apellido, string direccion, string telefono, string correo)
        {
            using (var db = new Conexion())
            {
                db.Insert(new clientes()
                {
                    nombre = nombre,
                    apellido = apellido,
                    telefono = telefono,
                    direccion = direccion,
                    correo = correo
                });
            }
        }

        public void buscarCliente(DataGridView DataGridView, string campo)
        {
            IEnumerable<clientes> query;
            if (campo == "")
            {
                query = from c in clientes select c;
            }
            else
            {
                query = from c in clientes
                        where c.nombre.Contains(campo) || c.apellido.Contains(campo)
                        select c;
            }
            DataGridView.DataSource = query.ToList();
            DataGridView.Columns[0].Visible = false;
            DataGridView.Columns[1].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            DataGridView.Columns[3].DefaultCellStyle.BackColor = Color.WhiteSmoke;
            DataGridView.Columns[5].DefaultCellStyle.BackColor = Color.WhiteSmoke;
        }

        public void updateCliente(string nombre, string apellido, string direccion, string telefono, string correo,
            int idCliente)
        {
            clientes.Where(c => c.idCliente == idCliente)
                .Set(c => c.nombre, nombre)
                .Set(c => c.apellido, apellido)
                .Set(c => c.telefono, telefono)
                .Set(c => c.direccion, direccion)
                .Set(c => c.correo, correo)
                .Update();
        }

        public void borrarCliente(int idCliente)
        {
            clientes.Where(c => c.idCliente == idCliente).Delete();
        }
    }
}

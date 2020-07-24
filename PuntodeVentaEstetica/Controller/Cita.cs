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
    class Cita : Conexion
    {
        public void buscarCitas(DataGridView dataGridView, string campo)
        {
            string fecha = DateTime.Now.ToString("dd/MMM/yyy");
            List<citas> query;
            if (campo.Equals(""))
            {
                query = citas.Where(c => c.fecha.Equals(fecha)).ToList();
            }
            else
            {
                query = citas.Where(p => p.nombre.Contains(campo) || p.fecha.Contains(campo) || p.hora.Contains(campo)).ToList();
            }
            dataGridView.DataSource = query;
            dataGridView.Columns[0].Visible = false;
        }

        internal void guardarCita(string nombre, string telefono, string servicio, DateTimePicker dtp, string hora)
        {

            var valorCita = citas.Where(p => p.nombre.Equals(nombre) && p.fecha.Equals(dtp.Value.Date.ToString("dd/MMM/yyy"))).ToList();
            if (valorCita.Count > 0)
            {
                citas.Where(p => p.idCita == valorCita[0].idCita)
                         .Set(p => p.nombre, nombre)
                         .Set(p => p.telefono, telefono)
                         .Set(p => p.concepto, servicio)
                         .Set(p => p.fecha, dtp.Value.Date.ToString("dd/MMM/yyy"))
                         .Set(p => p.hora, hora)
                         .Update();
            }
            else
            {
                citas.Value(p => p.nombre, nombre)
                         .Value(p => p.telefono, telefono)
                         .Value(p => p.concepto, servicio)
                         .Value(p => p.fecha, dtp.Value.Date.ToString("dd/MMM/yyy"))
                         .Value(p => p.hora, hora)
                         .Insert();
            }
        }

        public void borrar(int id)
        {
            var valorProducto = citas.Where(p => p.idCita == id).ToList();
            if(valorProducto.Count > 0)
            {
                citas.Where(p => p.idCita == id).Delete();
            }
        }
    }
}

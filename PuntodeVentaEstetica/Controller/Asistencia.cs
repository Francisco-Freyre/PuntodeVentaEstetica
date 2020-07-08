using LinqToDB;
using LinqToDB.Tools;
using PuntodeVentaEstetica.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVentaEstetica.Controller
{
    class Asistencia : Conexion
    {
        public void insertar(int idUsuario)
        {
            string fecha = DateTime.Now.ToString("dd/MMM/yyy") ;
            string hora = DateTime.Now.ToString("hh:mm:ss");
            var usuario = usuarios.Where(u => u.idUsuario.Equals(idUsuario)).ToList();
            if(usuario.Count > 0)
            {
                var asistencia = asistencias.Where(a => a.usuario.Equals(usuario[0].usuario) && a.fecha.Equals(fecha)).ToList();
                if(asistencia.Count > 0)
                {
                    asistencias.Where(a => a.idAsistencia.Equals(asistencia[0].idAsistencia))
                               .Set(a => a.horaSalida, hora)
                               .Update();
                }
                else
                {
                    asistencias.Value(a => a.usuario, usuario[0].usuario)
                               .Value(a => a.fecha, fecha)
                               .Value(a => a.horaEntrada, hora)
                               .Value(a => a.horaSalida, "--:--:--")
                               .Insert();
                }
            }
        }

        public void mostrar(DataGridView dgv)
        {
            string fecha = DateTime.Now.ToString("dd/MMM/yyy");
            var query = asistencias.Where(a => a.fecha.Contains(fecha)).ToList();
            dgv.DataSource = query;
            dgv.Columns[0].Visible = false;
        }
    }
}

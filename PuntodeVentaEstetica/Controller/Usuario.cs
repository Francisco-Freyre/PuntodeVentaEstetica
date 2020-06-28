using PuntodeVentaEstetica.Connection;
using PuntodeVentaEstetica.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntodeVentaEstetica.Controller
{
    class Usuario : Conexion
    {
        public List<usuarios> getUsuarios()
        {
            return usuarios.ToList();
        }

        internal bool registrarUsuario(string nombre, string apellido, string usuario, string contra)
        {
            bool valor = false;
            if(nombre == "")
            {

            }
            return valor;
        }
    }
}

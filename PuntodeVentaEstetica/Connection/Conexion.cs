using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB;
using LinqToDB.Data;
using PuntodeVentaEstetica.Model;

namespace PuntodeVentaEstetica.Connection
{
    class Conexion : DataConnection
    {
        public Conexion() : base("Estetica") { }

        public ITable<usuarios> usuarios { get { return GetTable<usuarios>(); } }

        public ITable<categorias> categorias { get { return GetTable<categorias>(); } }

        public ITable<productos> productos { get { return GetTable<productos>(); } }

        public ITable<clientes> clientes { get { return GetTable<clientes>(); } }

        public ITable<asistencias> asistencias { get { return GetTable<asistencias>(); } }

        public ITable<citas> citas { get { return GetTable<citas>(); } }

        public ITable<tempoVentas> tempoVentas { get { return GetTable<tempoVentas>(); } }

        public ITable<ventas> Ventas { get { return GetTable<ventas>(); } }

        public ITable<ventasTarjeta> ventasTarjeta { get { return GetTable<ventasTarjeta>(); } }

        public ITable<ventasClientes> ventasClientes { get { return GetTable<ventasClientes>(); } }

        public ITable<ingresos> ingresos { get { return GetTable<ingresos>(); } }

        public ITable<salidas> salidas { get { return GetTable<salidas>(); } }

        public ITable<entradas> entradas { get { return GetTable<entradas>(); } }
    }
}

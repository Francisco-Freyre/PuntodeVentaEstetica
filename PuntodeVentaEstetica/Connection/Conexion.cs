﻿using System;
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
    }
}

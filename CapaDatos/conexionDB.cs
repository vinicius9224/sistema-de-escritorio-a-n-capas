using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class conexionDB
    {

        private SqlConnection conexion = new SqlConnection("Server=DESKTOP-7C22NI8;DataBase=Sistema;Integrated Security=true");
        public SqlConnection Abrir()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
            return conexion;
        }
        public SqlConnection Cerrar()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
            return conexion;
        }



    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Linq;



namespace CapaDatos
{
   public class Alumnos
    {

        private conexionDB conexion = new conexionDB();


        DataTable tabla = new DataTable();

        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.Abrir();
            comando.CommandText = "select *from prueba1";
            SqlDataReader reader = comando.ExecuteReader();


            tabla.Load(reader);


            conexion.Cerrar();
            return tabla;
        }


    }
}

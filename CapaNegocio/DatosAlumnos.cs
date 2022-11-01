using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;


namespace CapaNegocio 
{
    public class DatosAlumnos
    {
        private Alumnos obj = new Alumnos();

        public DataTable Mostrar_completo()
        {

            DataTable tabla = new DataTable();
            tabla = obj.Mostrar();
            return tabla;
        }

    }
}

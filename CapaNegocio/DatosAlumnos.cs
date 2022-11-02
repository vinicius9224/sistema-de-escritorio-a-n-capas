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
        // se hace una instancia de la clase alumno que esta ubicada en la capa de datos
        private Alumnos obj = new Alumnos();
        // con este metodo se puede mostrar todo los registros que estan en la consulta o prodecimiento que se detallo en la capa de datos
        public DataTable Mostrar_completo()
        {
            // instanceamos la clase datatable
            DataTable tabla = new DataTable();
            tabla = obj.Mostrar();
            return tabla;
        }
        // agregamos los registros esto ya es para enviarselo mas facil a la capa de presentacion
        public void AgregarAlumno(string cod, string nom1, string nom2, string ape1, string ape2, string fecha, string nomRes, string colegio, string grado, string domiPersona, string evaluacion, string DeparId, string MuniId)
        {
          obj.Agregar_Alumnos(cod, nom1,  nom2,  ape1,  ape2, fecha ,  nomRes,  colegio,  grado, domiPersona, evaluacion, Convert.ToInt32(DeparId),  Convert.ToInt32(MuniId));
        }
    }
}

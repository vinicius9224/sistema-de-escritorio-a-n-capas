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
        //instanciar la clase conexion a la db
        private conexionDB conexion = new conexionDB();

        // intanciar los comandos sqlClient para poder utilizar las funciones
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        public DataTable Mostrar()
        {
            //Se abre la cadena de conexion con la clase.
            comando.Connection = conexion.Abrir();
            // se llama a la consulta o el procedimiento almacenado
            comando.CommandText = "MostrarAlumnos";
            // se especifica el tipo de comando si es text o procedure
            comando.CommandType = CommandType.StoredProcedure;
            // comienza a leer todo lo que hay en la db y si coincide con el procedure o en la consulta todo ok
            SqlDataReader reader = comando.ExecuteReader();
            // si la tabla esta cargada con los datos leidos todo ok.
            tabla.Load(reader);

            //cerramos la conexion
            conexion.Cerrar();
            return tabla;
        }

        // en este metodo se le pasa todos los atributos para que coincidan con los de la db (en orden a como estan en la tabla por ejemplo si es varchar tiene que ser string)
        public void Agregar_Alumnos(string cod ,string nom1, string nom2, string ape1, string ape2, string fecha , string nomRes, string colegio, string grado, string domiPersona, string evaluacion, int DeparId, int MuniId)
        {
            //abrimos la conexion
            comando.Connection = conexion.Abrir();
            // aca hacemos el transact sql (que es la consulta o el procedimiento almacenado)
            comando.CommandText = "insert into Alumnos values ('"+cod+"','"+nom1+"','"+nom2+"','"+ape1+"','"+ape2+"', '"+fecha+"','"+nomRes+"','"+colegio+"', '"+grado+"','"+domiPersona+"','"+evaluacion+"',"+DeparId+","+MuniId+")";
            // aca especificamos el tipo de comando para indicar si es consulta o procedimiento almacenado
            comando.CommandType = CommandType.Text;
            //operación para ejecutar cualquier instrucción SQL arbitraria en SQL Server si no desea que se devuelva ningún conjunto de resultados.
            comando.ExecuteNonQuery();
        }
   }
}

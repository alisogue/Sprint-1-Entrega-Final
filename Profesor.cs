using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WAnalisis
{
    /*Esta es la clase de Profesores donde vamos a manejar los metodos para insertar, modificar y eliminar los Profesores
    * Se realiza tambien la conexion con la base de datos*/

    public class Profesor
    {
        private SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-473U10EC\\SQLEXPRESS;Initial Catalog=Analisis;Integrated Security=True");
        private DataSet ds;

        //Metodo Insertar Profesores
        public bool Insertar(int cedula, string apellido1, string appelido2, string nombre, string correo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("insert into Profesor(CED_PROF,PRIMER_APELLIDO,SEGUNDO_APELLIDO,NOMBRE,CORREO_ELECTRONICO) values(" + cedula + ", '" + apellido1 + "', '" + appelido2 + "', '" + nombre + "', '" + correo + "')", conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }


        //Metodo Eliminar Profesores
        public bool Eliminar(int cedula)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("delete from Profesor where CED_PROF = " + cedula + "", conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }


        //Metodo Modificar Profesores
        public bool Modificar(int cedula, string apellido1, string apellido2, string nombre, string correo)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("Update Estudiante set CED_PROF = " + cedula + ",  PRIMER_APELLIDO = '" + apellido1 + "', SEGUNDO_APELLIDO = '" + apellido2 + "', NOMBRE= '" + nombre + "', CORREO_ELECTRONICO= '" + correo + "' where CED_PROF = " + cedula + "", conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }
    }
}
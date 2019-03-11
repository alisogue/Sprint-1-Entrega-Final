using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WAnalisis
{
    /*Esta es la clase de Estudiantes donde vamos a manejar los metodos para insertar, modificar y eliminar los Estudiantes
     * Se realiza tambien la conexion con la base de datos*/


    public class Estudiante
    {
        private SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-473U10EC\\SQLEXPRESS;Initial Catalog=Analisis;Integrated Security=True");
        private DataSet ds;

        //Metodo Insertar Estudiantes
        public bool Insertar(int cedula, string apellido1, string appelido2, string nombre, string correo, int idcarrera)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("insert into Estudiante(CED_EST,PRIMER_APELLIDO,SEGUNDO_APELLIDO,NOMBRE,CORREO_ELECTRONICO,ID_CARRERA) values(" + cedula + ", '" + apellido1 + "', '" + appelido2 + "', '" + nombre + "', '" + correo + "', " + idcarrera + ")", conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        //Metodo Eliminar Estudiantes
        public bool Eliminar(int cedula)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("delete from Estudiante where CED_EST = " + cedula + "", conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        //Metodo Modificar Estudiantes
        public bool Modificar(int cedula, string apellido1, string apellido2, string nombre, string correo, int idcarrera)
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("Update Estudiante set CED_EST = " + cedula +",  PRIMER_APELLIDO = '" + apellido1 + "', SEGUNDO_APELLIDO = '" + apellido2 + "', NOMBRE= '" + nombre + "', CORREO_ELECTRONICO= '" + correo + "', ID_CARRERA = " + idcarrera + " where CED_EST = " + cedula + "", conexion);
            int filasafectadas = cmd.ExecuteNonQuery();
            conexion.Close();
            if (filasafectadas > 0) return true;
            else return false;

        }
    }
}
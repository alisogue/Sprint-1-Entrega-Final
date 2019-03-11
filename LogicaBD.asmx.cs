using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WSA
{
    /// <summary>
    /// Descripción breve de LogicaBD
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class LogicaBD : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public String ConsultarClave(String User, String Pass)
        {
            String cadena = "";
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "Data Source=LAPTOP-473U10EC\\SQLEXPRESS;Initial Catalog=Analisis;Integrated Security=True";

            SqlDataAdapter Adpt = new SqlDataAdapter("SELECT COUNT(NOMBRE) as DATA FROM dbo.ESTUDIANTE WHERE NOMBRE='"
                + User + "' AND CED_EST='" + Pass + "'", conexion);

            DataSet ds = new DataSet();

            Adpt.Fill(ds);
            cadena = ds.Tables[0].Rows[0]["DATA"].ToString();
            return cadena;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WAnalisis
{
    //Esta es una masterpage para la pagina de Profesores. Aqui se llaman los metodos de insertar, modificar,
    //eliminar y buscar. Todos actualizando constantemente a la base de datos.

    public partial class Profesores : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private SqlConnection conexion = new SqlConnection("Data Source=LAPTOP-473U10EC\\SQLEXPRESS;Initial Catalog=Analisis;Integrated Security=True");


        //Se llama a la clase Profesores
        Profesor sql = new Profesor();


        //Boton que muestra solo las pantallas para Insertar datos
        protected void btn_Crear0_Click(object sender, EventArgs e)
        {
            ContentPlaceHolder6.Visible = true;
            ContentPlaceHolder5.Visible = false;
            ContentPlaceHolder7.Visible = false;

            txt_cedula.ReadOnly = false;
            txt_apellido1.ReadOnly = false;
            txt_apellido2.ReadOnly = false;
            txt_nombre.ReadOnly = false;
            txt_correo.ReadOnly = false;

            btn_guardar.Visible = true;
            btn_Cancelar.Visible = true;
            btn_actualizar.Visible = false;

            lbl_mensaje.Text = "";

        }

        //Boton que muestra solo las pantallas para Modificar datos
        protected void btn_Modificar0_Click(object sender, EventArgs e)
        {
            btn_actualizar.Visible = true;
            btn_Cancelar.Visible = true;
            btn_guardar.Visible = false;

            txt_cedula.ReadOnly = false;
            txt_apellido1.ReadOnly = false;
            txt_apellido2.ReadOnly = false;
            txt_nombre.ReadOnly = false;
            txt_correo.ReadOnly = false;

            ContentPlaceHolder5.Visible = true;
            ContentPlaceHolder6.Visible = true;
            ContentPlaceHolder7.Visible = false;

            lbl_mensaje.Text = "";
        }

        //Boton que muestra solo las pantallas para Eliminar datos
        protected void btn_Eliminar0_Click(object sender, EventArgs e)
        {
            btn_Cancelar0.Visible = true;
            btn_eliminar.Visible = true;
            btn_guardar.Visible = false;
            btn_Cancelar.Visible = false;
            btn_actualizar.Visible = false;

            txt_cedula.ReadOnly = true;
            txt_apellido1.ReadOnly = true;
            txt_apellido2.ReadOnly = true;
            txt_nombre.ReadOnly = true;
            txt_correo.ReadOnly = true;
            
            ContentPlaceHolder5.Visible = true;
            ContentPlaceHolder6.Visible = true;
            ContentPlaceHolder7.Visible = true;

            lbl_mensaje.Text = "";

        }

        //Boton de Insertar o Guardar
        protected void btn_guardar_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "";
            if (sql.Insertar(Convert.ToInt32(txt_cedula.Text), txt_apellido1.Text, txt_apellido2.Text, txt_nombre.Text, txt_correo.Text))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Datos insertados";

                txt_cedula.Text = "";
                txt_apellido1.Text = "";
                txt_apellido2.Text = "";
                txt_nombre.Text = "";
                txt_correo.Text = "";
            }
            else
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "No se ha podido insertar los datos";

                txt_cedula.Text = "";
                txt_apellido1.Text = "";
                txt_apellido2.Text = "";
                txt_nombre.Text = "";
                txt_correo.Text = "";
            }

        }

        //Boton para Cancelar
        protected void btn_Cancelar_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "";

            txt_cedula.Text = "";
            txt_apellido1.Text = "";
            txt_apellido2.Text = "";
            txt_nombre.Text = "";
            txt_correo.Text = "";
        }

        //Boton de Actualiar datos
        protected void btn_actualizar_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "";

            Buscar();

            if (sql.Modificar(Convert.ToInt32(txt_cedula.Text), txt_apellido1.Text, txt_apellido2.Text, txt_nombre.Text, txt_correo.Text))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Datos actualizados";

                txt_cedula.Text = "";
                txt_apellido1.Text = "";
                txt_apellido2.Text = "";
                txt_nombre.Text = "";
                txt_correo.Text = "";

            }
            else
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "No se ha podido actualizar los datos";

                txt_cedula.Text = "";
                txt_apellido1.Text = "";
                txt_apellido2.Text = "";
                txt_nombre.Text = "";
                txt_correo.Text = "";
            }
        }

        //Boton para Eliminar datos
        protected void btn_eliminar_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "";

            Buscar();

            if (sql.Eliminar(Convert.ToInt32(txt_cedulaBuscar0.Text)))
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "Datos eliminados";

                txt_cedula.Text = "";
                txt_apellido1.Text = "";
                txt_apellido2.Text = "";
                txt_nombre.Text = "";
                txt_correo.Text = "";
            }
            else
            {
                lbl_mensaje.Visible = true;
                lbl_mensaje.Text = "No se ha podido eliminar los datos";

                txt_cedula.Text = "";
                txt_apellido1.Text = "";
                txt_apellido2.Text = "";
                txt_nombre.Text = "";
                txt_correo.Text = "";
            }
        }

        //Segundo Boton de cancelar
        protected void btn_Cancelar0_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "";

            txt_cedula.Text = "";
            txt_apellido1.Text = "";
            txt_apellido2.Text = "";
            txt_nombre.Text = "";
            txt_correo.Text = "";
        }

        //Boton para buscar Profesores
        protected void btn_buscar_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "";

            //se llama el metodo buscar()
            Buscar();


        }

        //Este es el metodo buscar para encontrar a un profesor
        public void Buscar()
        {
            conexion.Open();
            string query = "select * from Profesor where CED_PROF = @id";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txt_cedulaBuscar0.Text));
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txt_cedula.Text = dr["Ced_Prof"].ToString();
                txt_apellido1.Text = dr["Primer_Apellido"].ToString();
                txt_apellido2.Text = dr["Segundo_Apellido"].ToString();
                txt_nombre.Text = dr["Nombre"].ToString();
                txt_correo.Text = dr["Correo_Electronico"].ToString();
            }

            conexion.Close();
        }
    }
}
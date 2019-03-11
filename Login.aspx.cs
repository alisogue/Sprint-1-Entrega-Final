using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAnalisis
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            if(DrpDw_listUsarios.Equals("Administrador"))
            {
                String Cadena = "Admin12345";

                if(Cadena.Equals(txt_Contrasena))
                {
                    Response.Redirect("Admin.aspx");
                }
                else
                {
                    lbl_mensaje.Visible = true;
                    lbl_mensaje.Text = "Contraseña incorrecta. Intente de nuevo.";
                }
                
            }
            else
            {
                String Cadena = "";
                WS.LogicaBDSoapClient WS = new WS.LogicaBDSoapClient();

                Cadena = WS.ConsultarClave(txt_Usuario.Text, txt_Contrasena.Text);

                if (Cadena == "1")
                {
                    Response.Redirect("Menu.aspx");
                }
                else
                {
                    lbl_mensaje.Visible = true;
                    lbl_mensaje.Text = "Contraseña incorrecta. Intente de nuevo.";
                }
            }
            

        }

        protected void btn_salir_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.google.com");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WAnalisis
{
    public partial class Admin1 : System.Web.UI.Page
    {
        protected void btn_Usuarios_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usuarios.aspx");
        }

        protected void btn_Roles_Click(object sender, EventArgs e)
        {
            Response.Redirect("Roles.aspx");
        }
    }
}
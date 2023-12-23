using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrabajoFinal
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var correo= new RecuperarPasswordBL();
            var result = correo.recoverPassword(txtgmail.Text);
            Label1.Text = result;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
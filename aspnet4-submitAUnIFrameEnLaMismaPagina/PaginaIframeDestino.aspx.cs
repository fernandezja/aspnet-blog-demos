using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PaginaIframeDestino : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (PreviousPage != null)
        {
            //Sin el atributo de pagina PreviousPageType 
            //TextBox txt = (TextBox)PreviousPage.FindControl("txtNombre");
            //string nombre = txt.Text;

            //Con el atributo de pagina PreviousPageType, 
            //tenemos acceso a intellisense de PreviousPage (que agregamos una propieddad publica) 
            string nombre = PreviousPage.Nombre;


            lblNombre.Text = nombre;
        }

        lblHora.Text = DateTime.Now.ToLongTimeString();
    }
}
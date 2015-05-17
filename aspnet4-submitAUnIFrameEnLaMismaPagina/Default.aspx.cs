using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public string Nombre {
        get {
            return txtNombre.Text;
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        lblHora.Text = DateTime.Now.ToLongTimeString();
    }
}

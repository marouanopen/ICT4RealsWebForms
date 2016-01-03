using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ICT4RealsWebForms.AdminSystem;
namespace ICT4RealsWebForms
{
    public partial class Loguit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Administration.LoggedInUser = null;
            Response.Redirect("Login.aspx");
        }
    }
}
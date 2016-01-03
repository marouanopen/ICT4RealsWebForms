using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ICT4RealsWebForms.AdminSystem;

namespace ICT4RealsWebForms
{
    public partial class Login : System.Web.UI.Page
    {
        private string username;
        private string password;
        public static Administration administration;
        protected void Page_Load(object sender, EventArgs e)
        {
            administration = new Administration();
        }

        /// <summary>
        /// constructor
        /// </summary>
        public Login()
        {
            
        }
        /// <summary>
        /// occurs when "btnlogin"is clicked
        /// </summary>
        /// <param name="sender">the control that was clicked</param>
        /// <param name="e"></param>
        public void btlogin_Click(object sender, EventArgs e)
        {
            username = (string)tbUserName.Text;
            password = (string)tbPassword.Text;
            try
            {
                if(administration.LogIn("beheerder@mail.com", "ict4reals"))
                //if (administration.LogIn(username, password))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You have succesfully logged in')", true);
                    if(Administration.LoggedInUser.Allowedpages.Contains("beheer"))
                    {
                        Response.Redirect("beheer.aspx");
                    }
                    else if(Administration.LoggedInUser.Allowedpages.Contains("inuitrij"))
                    {
                        Response.Redirect("InUitRij.aspx");
                    }
                    else if (Administration.LoggedInUser.Allowedpages.Contains("reparatie"))
                    {
                        Response.Redirect("Reparatie.aspx");
                    }
                    else if (Administration.LoggedInUser.Allowedpages.Contains("schoonmaak"))
                    {
                        Response.Redirect("Schoonmaak.aspx");
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Something went wrong when trying to login, please try again')", true);
                
                }
            }
            catch (NullReferenceException)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Something went wrong when trying to login, please try again')", true);
            }

        }
    }
}
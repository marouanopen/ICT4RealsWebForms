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
                //pseudo doquery met check of hij lines teruggeeft wanneer je naar password vraagt die bij ingevulde gebruikersnaam hoort
                //if so login met gebruiker met de data van die gebruiker uit de database //check in de administrationklasse
                //if (administration.LogIn(username, password))
                if(administration.LogIn("beheerder@mail.com", "ict4reals"))
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('You have succesfully logged in')", true);
                    Response.Redirect("beheer.aspx");
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Something went wrong when trying to login, please try again')", true);
                
                }
                if (Administration.LoggedInUser.RoleId == 1)
                {

                }
                if (Administration.LoggedInUser.RoleId == 2)
                {
                    ///rechten hier
                }
                if (Administration.LoggedInUser.RoleId == 3)
                {
                    //rechten hier
                }
                if (Administration.LoggedInUser.RoleId == 4)
                {
                    //rechten hier
                }
                if (Administration.LoggedInUser.RoleId == 5)
                {
                    ///rechten hier
                }
            }
            catch (NullReferenceException)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Something went wrong when trying to login, please try again')", true);
            }

        }
    }
}
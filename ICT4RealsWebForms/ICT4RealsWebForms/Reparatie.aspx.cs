using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ICT4RealsWebForms.DataBase;
using ICT4RealsWebForms.Service_System;
using ICT4RealsWebForms.Remise;
using ICT4RealsWebForms.AdminSystem;

namespace ICT4RealsWebForms
{
    public partial class Reparatie : System.Web.UI.Page
    {
        private Repairservice rpService = new Repairservice(1, "repair", DateTime.Today, DateTime.Today, 1, 1);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Administration.LoggedInUser != null)
            {
                if (!Administration.LoggedInUser.Allowedpages.Contains("reparatie"))
                {
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            UpdateRepairList();
            foreach (Service log in rpService.getAllLog())
            {
                lboxTramLog.Items.Add(log.ToString());
            }
        }

        protected void btnDetailsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Tram updateTram = null;
                string sub = lboxBrokeInList.SelectedItem.ToString().Substring(0, lboxBrokeInList.SelectedItem.ToString().IndexOf(" "));
                foreach (Tram t in Administration.GetTramList)
                {
                    if (t.Id == Convert.ToInt32(sub))
                    {
                        updateTram = t;
                    }
                }
                if (updateTram._Status == 4 && updateTram != null)
                {
                    updateTram._Status = 2;
                }
                else if (updateTram._Status == 3 && updateTram != null)
                {
                    updateTram._Status = 1;
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "My Alert", "Alert('Fout bij ophalen reparatielijst.')", true);
                }
            }
            catch
            {

            }
        }
        private void UpdateRepairList()
        {
            lboxBrokeInList.Items.Clear();
            foreach(string item in rpService.getAllStatus()){
                lboxBrokeInList.Items.Add(item);
            }
        }
    }
}
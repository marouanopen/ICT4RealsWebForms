using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ICT4RealsWebForms.AdminSystem;
using ICT4RealsWebForms.Service_System;
using ICT4RealsWebForms.Remise;

namespace ICT4RealsWebForms
{
    public partial class Schoonmaak : System.Web.UI.Page
    {
        private Cleaningservice clService = new Cleaningservice(1, "cleaning", DateTime.Today, DateTime.Today, 1, 1);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Administration.LoggedInUser != null)
            {
                if (!Administration.LoggedInUser.Allowedpages.Contains("schoonmaak"))
                {
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            if (!IsPostBack)
            {
                UpdateCleaingList();
                UpdateLogList();
            }
        }

        protected void btnDetailsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Tram updateTram = null;
                string sub = lboxDirtyInList.SelectedItem.ToString().Substring(0, lboxDirtyInList.SelectedItem.ToString().IndexOf(" "));
                foreach (Tram t in Administration.GetTramList)
                {
                    if (t.Id == Convert.ToInt32(sub))
                    {
                        updateTram = t;
                    }
                }
                if (updateTram._Status == 4 && updateTram != null)
                {
                    updateTram._Status = 3;
                    clService.update(updateTram.Id, updateTram._Status);
                    clService.UpdateLog(updateTram.Id);
                }
                else if (updateTram._Status == 2 && updateTram != null)
                {
                    updateTram._Status = 1;
                    clService.update(updateTram.Id, updateTram._Status);
                    clService.UpdateLog(updateTram.Id);
                }
                else
                {
                    ClientScript.RegisterStartupScript(GetType(), "My Alert", "Alert('Fout bij ophalen schoonmaaklijst.')", true);
                }
            }
            catch
            {

            }
            finally
            {
                UpdateCleaingList();
                UpdateLogList();
            }
        }
        private void UpdateCleaingList()
        {
            lboxDirtyInList.Items.Clear();
            foreach (string item in clService.getAllStatus())
            {
                lboxDirtyInList.Items.Add(item);
            }
        }

        private void UpdateLogList()
        {
            lboxTramLog.Items.Clear();
            foreach (Service log in clService.getAllLog())
            {
                lboxTramLog.Items.Add(log.ToString());
            }
        }
    }
}
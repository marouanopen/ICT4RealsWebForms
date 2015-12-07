using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserInterface_Mockup_ICT4Reals.DataBase;
using UserInterface_Mockup_ICT4Reals.Service;
using UserInterface_Mockup_ICT4Reals.Remise;

namespace ICT4RealsWebForms
{
    public partial class Reparatie : System.Web.UI.Page
    {
        private Repairservice rpService = new Repairservice(1, "repair", DateTime.Today, DateTime.Today, 1, 1);
        protected void Page_Load(object sender, EventArgs e)
        {
            foreach (string status in rpService.getAllStatus())
            {
                lboxBrokeInList.Items.Add(status);
            }
            foreach (Service log in rpService.getAllLog())
            {
                lboxTramLog.Items.Add(log.ToString());
            }
        }

        protected void btnDetailsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                /*
                Tram updateTram = null;
                string sub = lboxBrokeInList.SelectedItem.ToString().Substring(0, lboxBrokeInList.SelectedItem.ToString().IndexOf(" "));
                foreach (Tram t in Administration.GetTramList)
                {
                    if (t.Id == Convert.ToInt32(sub))
                    {
                        trammetje = t;
                    }
                }
                if (trammetje._Status == 4 && trammetje != null)
                {
                    trammetje._Status = 2;
                }
                else if (trammetje._Status == 3 && trammetje != null)
                {
                    trammetje._Status = 1;
                }
                else
                {
                    MessageBox.Show("Error");
                }
                 */
            }
            catch
            {

            }
        }
    }
}
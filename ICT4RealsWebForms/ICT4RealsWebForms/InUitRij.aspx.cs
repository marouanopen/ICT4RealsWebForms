using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UserInterface_Mockup_ICT4Reals.AdminSystem;
using UserInterface_Mockup_ICT4Reals.Remise;
using UserInterface_Mockup_ICT4Reals.DataBase;
using UserInterface_Mockup_ICT4Reals.Service;

namespace ICT4RealsWebForms
{
    public partial class InUitRij : System.Web.UI.Page
    {
        private Administration administration;
        private Parkingsystem parkingsystem;
        private PAdatabase padatabase;
        private Cleaningservice clService = new Cleaningservice(1, "cleaning", DateTime.Today, DateTime.Today, 1, 1);
        private Repairservice rpService = new Repairservice(1, "repair", DateTime.Today, DateTime.Today, 1, 1);
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlStatus.Items.Add("Ok");
            ddlStatus.Items.Add("Vies");
            ddlStatus.Items.Add("Defect");
            ddlStatus.Items.Add("Vies en Defect");
        }
        private void btnIncomingTram_Click(object sender, EventArgs e)
        {
            Rail rail = null;
            Tram tram = null;
            int status = 0;
            string soort = "";
            status = ddlStatus.SelectedIndex;
            int tramnr;
            bool exist = false;
            bool res = int.TryParse(tbTramnr.Text, out tramnr);
            if (res == false)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('The input should consist of numbers only!')", true);
            }
            else
            {
                foreach (Tram t in Administration.GetTramList)
                {
                    if (t.Id == tramnr)
                    {
                        exist = true;
                        tram = t;
                    }
                }
                if (exist == true)
                {
                    if (tram.OnRail)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('The tram is already parked and should be on its rail.')", true);
                    }
                    else
                    {
                        if (tram.Rail.IsRailBlocked(tram.Rail.Id))
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('This rail is blocked')", true);
                        }
                        else
                        {
                            rail = parkingsystem.InsertTramNr(Convert.ToInt32(tbTramnr.Text), status);
                            tram._Status = status;
                            if (status == 2)
                            {
                                soort = "Schoonmaak";
                            }
                            else if (status == 3)
                            {
                                soort = "Reparatie";
                            }
                            else if (status == 4)
                            {
                                soort = "Beide";
                            }
                            if (soort != "")
                            {
                                padatabase.MakeService(tramnr, soort);
                            }
                            tram.OnRail = true;
                            if (!padatabase.RefreshTramdatabase(tramnr))
                            {
                                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('The database wasn't updated.')", true);
                            }
                        }
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('A Tram with that number doesn't exist! Input a valid tramnumber!')", true);
                }

                if (rail != null)
                {
                    lblBigLabel.Text = Convert.ToString(rail.Id);

                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('The Assigned rail does not exist or is blocked')", true);
                }
            }

            remiseRefresh();
        }

        private void btnUitrijden_Click(object sender, EventArgs e)
        {
            bool exist = false;
            int tramnr;
            Tram tram = null;
            bool res = int.TryParse(ddlTramOut.Text, out tramnr);
                foreach (Tram t in Administration.GetTramList)
                {
                    if (t.Id == tramnr)
                    {
                        exist = true;
                        tram = t;
                    }
                }
                if (exist == true && tram.OnRail == true)
                {
                    if (tram._Status == 1)
                    {
                        tram.OnRail = false;
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('The tram is no longer parked')", true);
                        padatabase.RefreshTramdatabase(tramnr);
                        administration.UpdateTramList();
                        remiseRefresh();
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('The tram still needs cleaning or rapairs.')", true);
                    }
                    remiseRefresh();
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('A Tram with that number isn't parked yet! Input a tramnumber of a parked tram!')", true);
                }
            }
        private void remiseRefresh()
        {
            /*List<Tram> trams = Administration.GetTramList;

            foreach (Control c in groupBox1.Controls)
            {
                if (c.Name.StartsWith("spoor"))
                {
                    c.Text = "";
                    c.BackColor = Color.White;
                }

            }

            foreach (Tram t in trams)
            {
                if (t.OnRail)
                {
                    Rail rail = t.Rail;

                    string id = Convert.ToString(rail.Id);
                    Control c = groupBox1.Controls.Find("spoor" + id, true).FirstOrDefault();
                    c.Text = Convert.ToString(t.Id);
                    c.BackColor = Color.DimGray;
                }
            }*/
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ICT4RealsWebForms.AdminSystem;
using ICT4RealsWebForms.Remise;
using ICT4RealsWebForms.DataBase;
using ICT4RealsWebForms.Service_System;

namespace ICT4RealsWebForms
{
    public partial class InUitRij : System.Web.UI.Page
    {
        private Administration administration;
        private Parkingsystem parkingsystem;
        private PAdatabase padatabase;
        private RAdatabase railDatabase;
        private List<Rail> Possibletracks;
        private Cleaningservice clService = new Cleaningservice(1, "cleaning", DateTime.Today, DateTime.Today, 1, 1);
        private Repairservice rpService = new Repairservice(1, "repair", DateTime.Today, DateTime.Today, 1, 1);
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Administration.LoggedInUser != null)
            {
                if (!Administration.LoggedInUser.Allowedpages.Contains("inuitrij"))
                {
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }
            
            administration = Login.administration;
            if (!IsPostBack)
            {
                ddlStatus.Items.Clear();
                ddlStatus.Items.Add("Ok");
                ddlStatus.Items.Add("Vies");
                ddlStatus.Items.Add("Defect");
                ddlStatus.Items.Add("Vies en Defect");
                Updatedll();
            }
            this.parkingsystem = new Parkingsystem();
            this.padatabase = new PAdatabase();
            this.railDatabase = new RAdatabase();
        }
        public Rail ReturnRail(Tram tram)
        {
            Rail rail = null;
            Possibletracks = new List<Rail>();
            //controleer bestaande rails. 
            administration.UpdateRailList();
            //check blokkade
            //check taken?            
            foreach(Rail r in Administration.GetRailList)
            {
                if (Convert.ToInt32(railDatabase.IsRailBlocked(r.Id)) == 0)
                {
                    if(r.Taken == false)
                    {
                        if(r.Type == tram.Type)
                        {
                            Possibletracks.Add(r);
                        }
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('The rail is blocked!')", true);
                }
            }
            foreach(Rail r in Possibletracks)
            {
                if(r.Taken == false)
                {
                    return r;
                }

            }
            //check typeallowed
            //check eerstvolgende van die rail
            //return
            return rail;
        }
        public void btnIncomingTram_Click(object sender, EventArgs e)
        {
            Rail rail = null;
            Tram tram = null;
            int status = 0;
            string soort = "";
            status = ddlStatus.SelectedIndex + 1;
            int tramnr;
            bool exist = false;
            bool res = int.TryParse(tbTramnr.Text, out tramnr);
            try
            {
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
                        rail = ReturnRail(tram);
                        tram.Rail = rail;
                        if (tram.Rail.Taken)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('A tram is already parked here. Unable to park this tram right now.')", true);
                        }
                        else
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
                                    try
                                    {
                                        //rail = parkingsystem.InsertTramNr(Convert.ToInt32(tbTramnr.Text), status);
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
                                        tram.Rail.Taken = true;
                                        if (!padatabase.RefreshRaildatabase(tram.Rail.Id, 1))
                                        {
                                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('The raildatabase wasn't updated.')", true);
                                        }
                                        ///Fix update raillist
                                        if (!padatabase.RefreshTramdatabase(tramnr))
                                        {
                                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('The tramdatabase wasn't updated.')", true);
                                        }
                                    }
                                    catch (NullReferenceException)
                                    {
                                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "A rail with that number doesnt exist.", true);
                                    }
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
            }
            catch(NullReferenceException)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('A nullreference exception occured. Fix your code!')", true);
            }
            Updatedll();
        }

        public void Assign(Tram tram)
        {
            Rail rail = null;
            int status = 1;
            int tramnr = tram.Id;
            bool exist = false;
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
                        rail = ReturnRail(tram);
                        tram.Rail = rail;
                        if (tram.Rail.Taken)
                        {
                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('A tram is already parked here. Unable to park this tram right now.')", true);
                        }
                        else
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
                                    try
                                    {
                                        //rail = parkingsystem.InsertTramNr(Convert.ToInt32(tbTramnr.Text), status);
                                        tram._Status = status;
                                        tram.OnRail = true;
                                        tram.Rail.Taken = true;
                                        if (!padatabase.RefreshRaildatabase(tram.Rail.Id, 1))
                                        {
                                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('The raildatabase wasn't updated.')", true);
                                        }
                                        ///Fix update raillist
                                        if (!padatabase.RefreshTramdatabase(tramnr))
                                        {
                                            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('The tramdatabase wasn't updated.')", true);
                                        }
                                    }
                                    catch (NullReferenceException)
                                    {
                                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "A rail with that number doesnt exist.", true);
                                    }
                                }
                            }
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
            Updatedll();
        }
        public void btnUitrijden_Click(object sender, EventArgs e)
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
                        foreach(Rail r in Administration.GetRailList)
                        {
                            if(r.Id == tram.Rail.Id)
                            {
                                tram.Rail.Taken = false;
                            }
                        }
                        padatabase.RefreshRaildatabase(tram.Rail.Id, 0);
                        administration.UpdateRailList();
                        Updatedll();
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('The tram still needs cleaning or rapairs.')", true);
                    }
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('A Tram with that number isn't parked yet! Input a tramnumber of a parked tram!')", true);
                }
            }
        public void Updatedll()
        {
            ddlTramOut.Items.Clear();
            Administration.GetTramList.Sort(new SortTramAsc());
            foreach (Tram t in Administration.GetTramList)
            {
                if (t.OnRail)
                {
                    ddlTramOut.Items.Add(Convert.ToString(t.Id));
                }

            }
        }
        public void remiseRefresh()
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
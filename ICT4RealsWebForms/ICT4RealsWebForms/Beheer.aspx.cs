using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ICT4RealsWebForms.Remise;
using ICT4RealsWebForms.AdminSystem;
using System.Drawing;

namespace ICT4RealsWebForms
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            refreshGUI();
        }
        /// <summary>
        /// Refresh the gui to have the trams on the right location
        /// </summary>
        private void refreshGUI()
        {
            
            List<Tram> trams = Administration.GetTramList;

            /*
            foreach (Control c in groupBox1.Controls)
            {
                if (c.Name.StartsWith("spoor"))
                {
                    c.Text = "";
                    c.BackColor = Color.White;
                }

            }
            */
            try
            {
                foreach (Tram t in trams)
                {
                    if (t.OnRail)
                    {
                        Rail rail = t.Rail;

                        string id = Convert.ToString(rail.Id);
                        Label tlbl = (Label)FindControl("rail" + id);
                        tlbl.Text = Convert.ToString(t.Id);
                        tlbl.BackColor = Color.DimGray;
                    }
                }
            }
            catch (NullReferenceException)
            { 
            }
            
           

        }
    }
}
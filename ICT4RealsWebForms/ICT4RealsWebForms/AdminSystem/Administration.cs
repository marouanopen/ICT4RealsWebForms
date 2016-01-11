using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ICT4RealsWebForms.DataBase;
using ICT4RealsWebForms.Service_System;
using ICT4RealsWebForms.Remise;

namespace ICT4RealsWebForms.AdminSystem
{
    public class Administration
    {
        /// <summary>
        /// fields
        /// </summary>
        private ADdatabase addatabase = new ADdatabase();
        public List<Cleaningservice> GetSList { get; set; }
        public List<Repairservice> GetRList { get; set; }
        public static List<Rail> GetRailList { get; set; }
        public static List<Tram> GetTramList { get; set; }
        public static User LoggedInUser { get; set; }

        /// <summary>
        /// constructor, initializes the lists and updates them
        /// </summary>
        public Administration()
        {
            GetRailList = new List<Rail>();
            GetTramList = new List<Tram>();
            UpdateRailList();
            UpdateTramList();
        }

        /// <summary>
        /// not implemented
        /// </summary>
        /// <param name="tram"></param>
        /// <returns></returns>
        public bool AddTram(Tram tram)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// not implemented
        /// </summary>
        /// <param name="tram"></param>
        /// <returns></returns>
        public bool DeleteTram(Tram tram)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// not implemented
        /// </summary>
        /// <param name="tram"></param>
        /// <returns></returns>
        public bool MoveTram(Tram tram)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// not implemented
        /// </summary>
        /// <param name="rail"></param>
        /// <returns></returns>
        public bool BlockRail(Rail rail)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// notimplemented
        /// </summary>
        /// <param name="tram"></param>
        /// <returns></returns>
        public bool TramToDepartment(Tram tram)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// logs the user in
        /// </summary>
        /// <param name="username">username of the user</param>
        /// <param name="password">matching password</param>
        /// <returns>bool indicating succes</returns>
        public bool LogIn(string username, string password)
        {
            foreach (Dictionary<string, object> D in addatabase.Getuserpassword(username))
            {
                if ((string)D["wachtwoord"] == password)
                {
                    LoggedInUser = new User(Convert.ToInt32(D["gebruikerid"]), (string)D["naam"], (string)D["email"], Convert.ToInt32(D["functieid"]));
                    return true;
                }
            }
            return false;
        }
        public void UpdateRailList()
        {
            GetRailList.Clear();
            foreach (Dictionary<string, object> R in addatabase.GetAllRails())
            {
                bool status = false;
                bool taken = false;
                if (Convert.ToInt32(R["blokkeer"]) == 0)
                {
                    status = false;
                }
                else
                {
                    status = true;
                }
                if (Convert.ToInt32(R["taken"]) == 0)
                {
                    taken = false;
                }
                else
                {
                    taken = true;
                }

                Rail r = new Rail(Convert.ToInt32(R["spoorid"]), status, taken, Convert.ToInt32(R["remiseid"]), Convert.ToString(R["type"]));
                GetRailList.Add(r);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<Rail> GetRailsOfType(string type)
        {
            List<Rail> railSStoAuswitch = new List<Rail>();
            foreach (Dictionary<string, object> R in addatabase.GetAllRailsOfType(type))
            {
                bool status = false;
                bool taken = false;
                if (Convert.ToInt32(R["blokkeer"]) == 0)
                {
                    status = false;
                }
                else
                {
                    status = true;
                }
                if (Convert.ToInt32(R["taken"]) == 0)
                {
                    taken = false;
                }
                else
                {
                    taken = true;
                }

                Rail r = new Rail(Convert.ToInt32(R["spoorid"]), status, taken, Convert.ToInt32(R["remiseid"]), Convert.ToString(R["type"]));
                railSStoAuswitch.Add(r);
            }
            return railSStoAuswitch;
        }
        /// <summary>
        /// addon for enabling tabs. not used anymore
        /// </summary>
        /// <param name="page"></param>
        /// <param name="boolean"></param>
        // public void EnableTab(TabPage page, bool boolean)
        //{
        //    foreach (Control ctl in page.Controls) ctl.Enabled = boolean;
        //}
        public void UpdateTramList()
        {
            GetTramList.Clear();
            try
            {
                foreach (Dictionary<string, object> T in addatabase.GetAllTrams())
                {
                    Rail rail = null;
                    int status = 0;
                    bool onRail = false;

                    if ((string) T["status"] == "Ok")
                    {
                        status = 1;
                    }
                    if ((string) T["status"] == "Vies")
                    {
                        status = 2;
                    }
                    if ((string) T["status"] == "Defect")
                    {
                        status = 3;
                    }
                    if ((string) T["status"] == "ViesEnDefect")
                    {
                        status = 4;
                    }
                    if (Convert.ToInt32(T["aanwezigopspoor"]) == 0)
                    {
                        onRail = false;
                    }
                    else
                    {
                        onRail = true;
                    }
                    foreach (Rail R in Administration.GetRailList)
                    {
                        if (R.Id == Convert.ToInt32(T["spoorid"]))
                        {
                            rail = R;

                        }
                    }

                    Tram t = new Tram(Convert.ToInt32(T["tramid"]), (string) T["type"], rail, LoggedInUser, status,
                        onRail);
                    GetTramList.Add(t);
                }
            }
            catch 
            {
                
            }
        }
    }
}

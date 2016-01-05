using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICT4RealsWebForms.DataBase;

namespace ICT4RealsWebForms.DataBase
{
    class REdatabase : Database
    {
        /// <summary>
        /// updates the rapair part of the database
        /// </summary>
        /// <param name="tramID">tram id</param>
        /// <param name="StatusID">id of the status</param>
        /// <returns>returns bool representing succes</returns>
        public bool updateRepair(int tramID, int StatusID)
        {
            try
            {

                string query;
                query = "UPDATE tram_status SET";
                query += " statusStatusID =" + StatusID + " WHERE TramTramID = " + tramID;
                doQuery(query); //query will be activated
                return true;
            }
            catch
            {
                return false;   // if query fails, return a false.
            }
        }
        /// <summary>
        /// checks if the service can be assigned, compared to the maxservices that can be done in one day
        /// </summary>
        /// <returns>returns bool representing succes</returns>
        public bool controleMax()
        {
            int bigcount = 0;
            int smallcount = 0;

            List<Dictionary<string, object>> ret = GetAlllogs();
            foreach (Dictionary<string, object> logs in ret)
            {
                if (Convert.ToString(logs["soort"]) == "Reparatie")
                {
                    bigcount++;
                }
                if( smallcount > 4 || bigcount > 100)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Alle trams met vies of deffect</returns>
        public List<Dictionary<string, object>> GetAllStatus() //name of ur query
        {
            List<Dictionary<string, object>> ret = getQuery("SELECT TramTramID, StatusStatusID FROM tram_status WHERE statusStatusID = 3 OR statusStatusID = 4 ");
            return ret;     //this will return the list as result from the query.
        }
        /// <summary>
        /// update trams after repair
        /// </summary>
        /// <param name="tramID">current tram id</param>
        /// <param name="date">current date</param>
        /// <returns></returns>
        public bool updateLog(int tramID, DateTime date, int superbeurt)
        {
            try
            {
                string query;
                query = "UPDATE Beurt SET ";
                query +=  "Einddatum = to_date('" + date.ToString("MM-dd-yyyy") + "','MM-DD-YYYY') , superbeurtID =" + superbeurt + " WHERE TramID = " + tramID;
                doQuery(query); //query will be activated
                return true;
            }
            catch
            {
                return false;   // if query fails, return a false.
            }
        }
        public List<Dictionary<string, object>> GetAlllogs() //name of ur query
        {
            List<Dictionary<string, object>> ret = getQuery("SELECT BeurtID, Soort, BeginDatum, EindDatum, TramID, NVL(SuperBeurtID, '1'), NVL(type, 'Groot') FROM beurt WHERE soort = 'Reparatie' AND Einddatum IS NOT NULL");
            return ret;     //this will return the list as result from the query.
        }

    }
}

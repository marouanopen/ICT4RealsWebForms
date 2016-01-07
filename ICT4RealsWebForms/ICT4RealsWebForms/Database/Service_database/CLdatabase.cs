using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICT4RealsWebForms.DataBase;


namespace ICT4RealsWebForms.DataBase
{
    class CLdatabase : Database
    {
        public bool updateCleaning(int tramID, int StatusID)
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
        /// 
        /// </summary>
        /// <returns>Alle trams met vies of deffect</returns>
        public List<Dictionary<string, object>> GetAllStatus() //name of ur query
        {
            List<Dictionary<string, object>> ret = getQuery("SELECT TramTramID, StatusStatusID FROM tram_status WHERE statusStatusID = 2 OR statusStatusID = 4 ");
            return ret;     //this will return the list as result from the query.
        }
        /// <summary>
        /// update trams after repair
        /// </summary>
        /// <param name="tramID">current tram id</param>
        /// <param name="date">current date</param>
        /// <returns></returns>
        public bool updateLog(int tramID, DateTime date)
        {
            try
            {
                string query;
                query = "UPDATE Beurt SET ";
                query += "Einddatum = to_date('" + date.ToString("MM-dd-yyyy") + "','MM-DD-YYYY') , superbeurtID = null WHERE TramID = " + tramID;
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
            List<Dictionary<string, object>> ret = getQuery("SELECT BeurtID, Soort, BeginDatum, EindDatum, TramID, NVL(SuperBeurtID, '1'), NVL(type, 'Groot') FROM beurt WHERE soort = 'Schoonmaak' AND Einddatum IS NOT NULL");
            return ret;     //this will return the list as result from the query.
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICT4RealsWebForms.AdminSystem;
using ICT4RealsWebForms.Remise;
using ICT4RealsWebForms.DataBase;

namespace ICT4RealsWebForms.Service_System
{
    public class Repairservice : Service
    {
        /// <summary>
        /// fields
        /// </summary>
        REdatabase database = new REdatabase();

        public Repairservice(int id, string soort, DateTime startdate, DateTime enddate, int tramid, int superbeurtID)
            : base(id, soort, tramid, startdate, enddate, superbeurtID)
        {
            this.Id = id;
            this.soort = soort;
            this.startDate = startdate;
            this.endDate = enddate;
            this.tramID = tramid;
            this.superbeurtID = superbeurtID;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tramID"></param>
        /// <param name="StatusID"></param>
        /// <returns></returns>
        public bool update(int tramID, int StatusID)
        {

            if (database.updateRepair(tramID, StatusID))
            {
                return true;
            }
            else
            {
                return false;
            }

            return false;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<String> getAllStatus()
        {
            List<String> Allbroken = new List<String>();
            List<Dictionary<string, object>> results = database.GetAllStatus();
            foreach (Dictionary<string, object> tramLink in results)
            {
                string text = Convert.ToString(tramLink["tramtramid"]) + " - need repairs";
                Allbroken.Add(text);
            }
            return Allbroken;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Service> getAllLog()
        {
            List<Service> allService = new List<Service>();

            List<Dictionary<string, object>> results = database.GetAlllogs();

            foreach (Dictionary<string, object> log in results)
            {
                Service newservice = new Service(Convert.ToInt32(Convert.ToInt32(log["beurtid"])), Convert.ToString(log["soort"]), Convert.ToInt32(log["tramid"]), Convert.ToDateTime(log["begindatum"]), DateTime.Today, 0);

                allService.Add(newservice);
            }
            return allService;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tramID"></param>
        /// <param name="superbeurt"></param>
        /// <returns></returns>
        public bool UpdateLog(int tramID, int superbeurt)
        {
            DateTime date = DateTime.Now;
            if (database.updateLog(tramID, date, superbeurt))
            {
                return true;
            }
            else
            {
                return false;
            }

        }



    }
}

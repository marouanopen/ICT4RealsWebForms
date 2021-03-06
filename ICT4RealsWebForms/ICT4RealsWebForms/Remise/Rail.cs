﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICT4RealsWebForms.DataBase;

namespace ICT4RealsWebForms.Remise
{
    public class Rail
    {
        /// <summary>
        /// fields
        /// </summary>
        RAdatabase railDatabase = new RAdatabase();
        public int Id { get; set; }
        public bool Status { get; set; }
        public bool Taken { get; set; }
        public int RemiseID { get; set; }
        public string Type { get; set; }
        public Rail(int id, bool status, bool taken, int remiseid, string type)
        {
            this.Id = id;
            this.Status = status;
            this.Taken = taken;
            this.RemiseID = RemiseID;
            this.Type = type;
        }
        /// <summary>
        /// See if the rail is blocked
        /// </summary>
        /// <param name="railNumber">Give the railnumber of which you want to look for</param>
        /// <returns>false if rail is free and return true if rail is blocked</returns>
        public bool IsRailBlocked(int railNumber)
        {
            bool Railblocked = false;
            if (Convert.ToInt32(railDatabase.IsRailBlocked(railNumber)) == 0)
            {
                Railblocked = false;
            }
            else if (Convert.ToInt32(railDatabase.IsRailBlocked(railNumber)) == 1)
            {
                Railblocked = true;
            }
            return Railblocked;
        }

        /// <summary>
        /// Block the rail
        /// </summary>
        /// <param name="railNumber">The railnumber you want to block</param>
        /// <param name="block">give 1 to block or 0 to unblock</param>
        /// <returns>true if succeed, false if failed</returns>
        public bool BlockRail(int railNumber, int block)
        {
            bool blockRail = false;
            if (railDatabase.BlockRail(railNumber, block))
            {
                // MessageBox.Show("Gelukt!");
                blockRail = true;
            }
            else
            {
                // MessageBox.Show("Error!");
            }
            return blockRail;
        }
    }
}

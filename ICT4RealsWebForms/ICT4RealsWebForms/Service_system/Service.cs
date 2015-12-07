using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICT4RealsWebForms.DataBase;
using ICT4RealsWebForms.AdminSystem;
using ICT4RealsWebForms.Remise;
namespace ICT4RealsWebForms.Service
{
    public class Service
    {
        /// <summary>
        /// fields
        /// </summary>
        public int Id { get; set; }
        public string soort { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int tramID { get; set; }
        public int superbeurtID { get; set; }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="id"></param>
        /// <param name="soort"></param>
        /// <param name="tramid"></param>
        /// <param name="startdate"></param>
        /// <param name="enddate"></param>
        /// <param name="superbeurtID"></param>
        public Service(int id, string soort, int tramid, DateTime startdate, DateTime enddate, int superbeurtID)
        {
            this.Id = id;
            this.soort = soort;
            this.endDate = enddate;
            this.startDate = startDate;
            this.tramID = tramid;
            this.superbeurtID = superbeurtID;
        }

        public override string ToString()
        {
            return "ID: " + Id + ", TramID: " + tramID + ", Start datum: " + startDate + ", Eind Datum: " + endDate;
        }
    }
}

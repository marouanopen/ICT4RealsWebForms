using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4RealsWebForms.AdminSystem
{
    public class User
    {
        /// <summary>
        /// fields
        /// </summary>
        RoleType Role;
        public int RoleId { get { return (int)Role; } }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public List<string> Allowedpages { get; set; }
        
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="id">id of the user</param>
        /// <param name="name">name of the user</param>
        /// <param name="username">username of the user (represented by email)</param>
        /// <param name="roleId">role represented by the enum</param>
        public User(int id, string name, string username, int roleId)
        {
            Allowedpages = new List<string>();
            this.Id = id;
            this.Name = name;
            this.Username = username;
            Role = (RoleType)roleId;
            if (RoleId == 1)
            {
                Allowedpages.Add("beheer");
                Allowedpages.Add("inuitrij");
                Allowedpages.Add("raparatie");
                Allowedpages.Add("schoonmaak");
            }
            if (RoleId == 2)
            {
                Allowedpages.Add("inuitrij");
            }
            if (RoleId == 3)
            {
                Allowedpages.Add("beheer");
            }
            if (RoleId == 4)
            {
                Allowedpages.Add("raparatie");
            }
            if (RoleId == 5)
            {
                Allowedpages.Add("schoonmaak");
            }
        }

    }
}

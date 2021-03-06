﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4RealsWebForms.DataBase
{
    class ADdatabase : Database
    {
        /// <summary>
        /// a method that gets the password from the database of the user that is trying to login
        /// </summary>
        /// <param name="username">username that was filled in by the user</param>
        /// <returns>return a dictionary with password that match the username</returns>
        public List<Dictionary<string, object>> Getuserpassword(string username) //name of ur query
        {
            //List<string> ret = new List<string>(); //result of query will end up in here
            List<Dictionary<string, object>> user = getQuery("SELECT GebruikerID, Email, Naam, Achternaam, Wachtwoord, FunctieID, RemiseID FROM Gebruiker WHERE Email = '" + username + "'"); //replace your query with te example query, replace 'QueryX' with a clear name.
            /*foreach (Dictionary<string, object> results in user) //look for all posseble results in the query result.
            {
                ret.Add((Convert.ToString(results["gebruikerid"]),Convert.ToString(results["email"]),Convert.ToString(results["naam"]),Convert.ToString(results["achternaam"]),Convert.ToString(results["functieid"]),Convert.ToString(results["remiseid"])); //add each result to the created list, if the list if for a class, u need to add 'new class_name' infront of the convert
            }*/

            return user;     //this will return the list as result from the query.
        }
        /// <summary>
        /// gets all trams from the database
        /// </summary>
        /// <returns>returns a dictionary from the database with all trams known in the database</returns>
        public List<Dictionary<string, object>> GetAllTrams()
        {
            List<Dictionary<string, object>> trams = getQuery("select t.Tramid,t.spoorid, ty.type, s.Status, t.AanwezigOpSpoor  from tram t, Tram_Status ts, status s, type ty where t.tramid = ts.tramtramid and ts.StatusStatusID = s.statusid and ty.typeid = t.typeid"); //replace your query with te example query, replace 'QueryX' with a clear name.
            return trams;
        }
        /// <summary>
        /// gets all rails known in the database
        /// </summary>
        /// <returns>returns a dictionary from the datebase with all the rails known in the database</returns>
        public List<Dictionary<string, object>> GetAllRails()
        {
            List<Dictionary<string, object>> rails = getQuery("SELECT * FROM Spoor"); //replace your query with te example query, replace 'QueryX' with a clear name.
            return rails;
        }

        /// <summary>
        /// gets all rails with a certain type known in the database
        /// </summary>
        /// <returns>returns a dictionary from the datebase with all the rails known in the database</returns>
        public List<Dictionary<string, object>> GetAllRailsOfType(string type)
        {
            string queer = string.Format("SELECT * FROM Spoor WHERE blokkeer = 0 AND taken = 0 AND type = '{0}'", type);
            List<Dictionary<string, object>> rails = getQuery(queer);
            return rails;
        }

    }
}


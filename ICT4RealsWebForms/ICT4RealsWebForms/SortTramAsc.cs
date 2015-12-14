using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ICT4RealsWebForms.Remise;
namespace ICT4RealsWebForms
{
    public class SortTramAsc : IComparer<Tram>
    {
        public int Compare(Tram tram1, Tram tram2)
        {
            if (tram1.Id > tram2.Id)
                return 1;
            if (tram1.Id < tram2.Id)
                return -1;

            return 0;
        }
    }
}
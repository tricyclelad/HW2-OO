using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public class Athletes
    {
        List<Athlete> ListOfAthletes;
        
        public Athletes(List<Athlete> _ListOfAthletes)
        {
            ListOfAthletes = new List<Athlete>(_ListOfAthletes);
        }
    }
}

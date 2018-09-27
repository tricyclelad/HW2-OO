using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public class NewAthleteProcessor : MessageProcessor
    {
        public void Process(string[] Message, ref RaceManager _MyRaceManager)
        {
            foreach (var c in _MyRaceManager.MyClients)
            {
                //This is where the message would be sent through the communicator
                //to the clients
                //c.send message through communicator
                c.Update(); 
            }
        }
    }
}

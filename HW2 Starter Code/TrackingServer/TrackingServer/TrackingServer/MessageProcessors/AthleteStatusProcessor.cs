﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public class AthleteStatusProcessor : MessageProcessor
    {
        public void Process(string [] Message, ref RaceManager _MyRaceManager, System.Net.IPEndPoint senderEndPoint)
        {
            foreach (var c in _MyRaceManager.MyClients)
            {
                //This is where the message would be sent through the communicator
                //to the clients
                //c.send message through communicator
                //c.Update();
            }
        }
    }
}

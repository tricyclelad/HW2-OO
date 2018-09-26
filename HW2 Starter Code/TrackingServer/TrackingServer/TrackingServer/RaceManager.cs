using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base;

namespace TrackingServer
{
    public class RaceManager
    {
        Communicator MyCommunicator;// { get; set; } 
        Athletes MyRunners { get; set; }
        MessageProcessor MyMessageProcessor {get; set; }
        public RaceManager()
        {
            MyCommunicator = new Communicator(12000);
        }

        public void start()
        {
            MyCommunicator.Start();
        }

        public void stop()
        {
            MyCommunicator.Stop();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public class StartedUpdateProcessor : MessageProcessor
    {
        public void Process(string [] Message, ref RaceManager _MyRaceManager)
        {
            foreach (var athlete in _MyRaceManager.MyRunners)
            {
                if (athlete.bibNumber == Convert.ToInt32(Message[1]))
                {
                    athlete.startTime = Convert.ToInt32(Message[2]);
                    //Communicator Logic here
                }
            }
        }
    }
}

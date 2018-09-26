using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public class DidNotStartProcessor : MessageProcessor
    {
        public void Process(string [] Message, ref RaceManager _MyRaceManager)
        {
            foreach (var athlete in _MyRaceManager.MyRunners)
            {
                if (athlete.bibNumber == Convert.ToInt32(Message[1])) 
                {
                    athlete.startTime = 0;
                    athlete.finishTime = -1;
                    //Communicator Logic here
                }
            }
        }
    }
}

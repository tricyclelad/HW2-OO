using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public class FinishedUpdateProcessor : MessageProcessor
    {
        public void Process(string[] Message, ref RaceManager _MyRaceManager, System.Net.IPEndPoint senderEndPoint)
        {
            foreach (var athlete in _MyRaceManager.MyRunners)
            {
                if (athlete.bibNumber == Convert.ToInt32(Message[1]))
                {
                    athlete.lastUpdatedTime = Convert.ToDouble(Message[2]);
                    athlete.finishTime = athlete.lastUpdatedTime - athlete.startTime; 
                    athlete.status = "Finished!";
                    //Communicator Logic here
                    
                }
            }
        }
    }
}

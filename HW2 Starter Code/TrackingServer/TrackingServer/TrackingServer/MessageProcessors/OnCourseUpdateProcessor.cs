using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public class OnCourseUpdateProcessor : MessageProcessor
    {
        public void Process(string[] Message, ref RaceManager _MyRaceManager)
        {
            foreach (var athlete in _MyRaceManager.MyRunners)
            {
                if (athlete.bibNumber == Convert.ToInt32(Message[1]))
                {
                    athlete.lastUpdatedTime = Convert.ToDouble(Message[2]);
                    athlete.distanceCovered = Convert.ToDouble(Message[3]);
                    //Communicator Logic here
                }
            }
        }
    }
}

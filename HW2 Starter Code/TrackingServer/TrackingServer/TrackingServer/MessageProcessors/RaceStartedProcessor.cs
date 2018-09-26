using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public class RaceStartedProcessor : MessageProcessor
    {
        public void Process(string[] Message, ref RaceManager _MyRaceManager)
        {
            _MyRaceManager.RaceName = Message[1];
            _MyRaceManager.CourseLength = Convert.ToDouble(Message[2]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public interface MessageProcessor
    {
        void Process(ref RaceManager _MyRaceManager);
    }
}

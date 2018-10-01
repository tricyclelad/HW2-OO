using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public class NewAthleteProcessor : MessageProcessor
    {
        public void Process(string[] Message, ref RaceManager _MyRaceManager, System.Net.IPEndPoint senderEndPoint)
        {
            
            //string outGoingMessage = "Status," + athlete.bibNumber + "," + athlete.status + "," + athlete.startTime + "," + athlete.distanceCovered + "," + athlete.lastUpdatedTime + "," + athlete.finishTime;
            //foreach (var c in _MyRaceManager.MyClients)
            //{
            //    _MyRaceManager.MyCommunicator.Send(outGoingMessage, client.MyEndPoint);
            //   // c.Update(); 
            //}
        }
    }
}

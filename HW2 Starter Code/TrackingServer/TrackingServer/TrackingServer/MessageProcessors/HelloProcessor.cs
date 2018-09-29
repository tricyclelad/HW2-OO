using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public class HelloProcessor : MessageProcessor
    {
        public void Process(string[] Message, ref RaceManager _MyRaceManager, System.Net.IPEndPoint senderEndPoint)
        {
            Client client = new Client(Message[1],Message[2]);
            _MyRaceManager.MyClients.Add(client);
            //Usually the communicator would have the ip and endpoint info,
            //but since I can't get it working, we'll pretend that the message
            // is hello,ip,endpoint.
        }
    }
}

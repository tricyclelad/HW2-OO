using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public class UnsubscribeProcessor : MessageProcessor
    {
        public void Process(string[] Message, ref RaceManager _MyRaceManager)
        {
            foreach (var client in _MyRaceManager.MyClients)
            {
                if (client.IPaddress==Message[2] && client.EndPoint==Message[3])
                {
                    foreach (var runner in _MyRaceManager.MyRunners)
                    {
                        if (Convert.ToInt32(Message[1]) == runner.bibNumber)
                        {
                            runner.Detach(client);
                        }

                    }        

                }
            }

            //Since I can't get the communicator working, we'll pretend that the message is
            //in this order unsubscribe,bibnumber,ipaddress,endpoint
            
            
        }
    }
}

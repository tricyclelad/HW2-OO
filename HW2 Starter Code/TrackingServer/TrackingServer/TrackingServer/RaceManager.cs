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
        List<Athlete> MyRunners2 = new List<Athlete>();
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
        private static MessageProcessor GetMessageProcessor(string message)
        {
            string[] SplitMessage = message.Split(',');
            MessageProcessor _myProcessor = null;
            if(SplitMessage[0] == "Race")
            {
                //do this thing.
            }
            else if (SplitMessage[0] == "Registered")
            {

            }
            else if (SplitMessage[0] == "DidNotStart")
            {

            }
            else if (SplitMessage[0] == "Started")
            {

            }
            else if (SplitMessage[0] == "OnCourse")
            {

            }
            else if (SplitMessage[0] == "DidNotFinish")
            {

            }
            else if (SplitMessage[0] == "Finished")
            {

            }
            else if (SplitMessage[0] == "Hello")
            {

            }
            else if (SplitMessage[0] == "Subscribe")
            {

            }
            else if (SplitMessage[0] == "Unsubscribe")
            {

            }
            else if (SplitMessage[0] == "Athlete")
            {

            }
            else if (SplitMessage[0] == "Status")
            {

            }
        }
        
    }
}

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
        string RaceName { get; set; }
        double CourseLength { get; set;  }

        public RaceManager()
        {
            MyCommunicator = new Communicator(12000);
           
        }

        public void start()
        {
            MyCommunicator.Start();
            string MessageFromCommunicator = "Race";
            string[] SplitMessage = MessageFromCommunicator.Split(',');
            MyMessageProcessor = GetMessageProcessor(MessageFromCommunicator);
            var temp = this;
            MyMessageProcessor.Process(SplitMessage, ref temp);

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
                _myProcessor = new RaceStartedProcessor();
                return _myProcessor;
            }
            else if (SplitMessage[0] == "Registered")
            {
                _myProcessor = new RegisteredUpdateProcessor();
                return _myProcessor;
            }
            else if (SplitMessage[0] == "DidNotStart")
            {
                _myProcessor = new DidNotStartProcessor(); 
                return _myProcessor;
            }
            else if (SplitMessage[0] == "Started")
            {
                _myProcessor = new StartedUpdateProcessor(); 
                return _myProcessor;
            }
            else if (SplitMessage[0] == "OnCourse")
            {
                _myProcessor = new OnCourseUpdateProcessor(); 
                return _myProcessor;
            }
            else if (SplitMessage[0] == "DidNotFinish")
            {
                _myProcessor = new DidNotFinishUpdateProcessor(); 
                return _myProcessor;
            }
            else if (SplitMessage[0] == "Finished")
            {
                _myProcessor = new FinishedUpdateProcessor(); 
                return _myProcessor;
            }
            else if (SplitMessage[0] == "Hello")
            {
                _myProcessor = new HelloProcessor(); 
                return _myProcessor;
            }
            else if (SplitMessage[0] == "Subscribe")
            {
                _myProcessor = new SubscribeProcessor(); 
                return _myProcessor;
            }
            else if (SplitMessage[0] == "Unsubscribe")
            {
                _myProcessor = new UnsubscribeProcessor(); 
                return _myProcessor;
            }
            else if (SplitMessage[0] == "Athlete")
            {
                _myProcessor = new NewAthleteProcessor(); 
                return _myProcessor;
            }
            else if (SplitMessage[0] == "Status")
            {
                _myProcessor = new AthleteStatusProcessor(); 
                return _myProcessor;
            }
            return _myProcessor;
        }
        
    }
}

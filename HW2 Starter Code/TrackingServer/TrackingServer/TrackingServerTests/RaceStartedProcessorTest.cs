using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrackingServer;
using Base;

namespace TrackingServerTests
{
    [TestClass]
    public class RaceStartedProcessorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            RaceManager MyRaceManager = new RaceManager();
            Client myClient = new Client("127.0.0.1", "12000");
            MyRaceManager.MyClients.Add(myClient);
            string MessageFromCommunicator = "Race,RaceName,100";
            string[] SplitMessage = MessageFromCommunicator.Split(',');
            MyRaceManager.MyMessageProcessor = MyRaceManager.GetMessageProcessor(MessageFromCommunicator);
            MyRaceManager.MyMessageProcessor.Process(SplitMessage, ref MyRaceManager);
            Assert.AreEqual(MyRaceManager.RaceName,"RaceName" ); 
            Assert.AreEqual(MyRaceManager.CourseLength,100); 
        }
    }
}

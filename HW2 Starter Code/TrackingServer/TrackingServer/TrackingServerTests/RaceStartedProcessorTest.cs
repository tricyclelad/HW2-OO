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
            Communicator MyCommunicator = new Communicator(12000);
            MessageProcessor MyMessageProcessor;
            //MyCommunicator.Start();
            RaceManager MyRaceManager = new RaceManager();
            MyRaceManager.start();
            //string MessageFromCommunicator = "Race, RaceName, 100";
            //string[] SplitMessage = MessageFromCommunicator.Split(',');
            //MyMessageProcessor = RaceManager.GetMessageProcessor(MessageFromCommunicator);
            //var temp = this;
            //MyMessageProcessor.Process(SplitMessage, ref temp);
        }
    }
}

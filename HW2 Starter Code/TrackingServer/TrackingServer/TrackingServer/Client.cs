using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public class Client : Observer
    {
        //public string IPaddress { get; set; }
        //public string EndPoint { get; set; }
        public System.Net.IPEndPoint MyEndPoint;

        public Athlete MyAthleteSubject
        {
            get => default(Athlete);
            set
            {
            }
        }

        public Client(System.Net.IPEndPoint _EndPoint)
        {
            MyEndPoint = _EndPoint;
        }

        public override void Update()
        {
            //Console.WriteLine(IPaddress+ " " + EndPoint + " Got an update.");
            Console.WriteLine(MyEndPoint.Address+ " " + MyEndPoint.Port + " Got an update.");
            //Logic for communication would go here
        }
    }
}

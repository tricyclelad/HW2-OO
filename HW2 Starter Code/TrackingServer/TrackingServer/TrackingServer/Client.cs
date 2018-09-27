using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    public class Client : Observer
    {
        public string IPaddress { get; set; }
        public string EndPoint { get; set; }

        public Athlete Subject
        {
            get => default(Athlete);
            set
            {
            }
        }

        public Client(string _IPaddress, string _EndPoint)
        {
            IPaddress = _IPaddress;
            EndPoint = _EndPoint; 
        }

        public override void Update()
        {
            Console.WriteLine(IPaddress+ " " + EndPoint + " Got an update.");
            //Logic for communication would go here
        }
    }
}

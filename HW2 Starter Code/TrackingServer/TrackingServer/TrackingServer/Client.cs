using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingServer
{
    class Client : Observer
    {
        string IPaddress { get; set; }
        string EndPoint { get; set; }

        public override void Update()
        {
            Console.WriteLine(IPaddress+ " " + EndPoint + "Got an update.");
        }
    }
}

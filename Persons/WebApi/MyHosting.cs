using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class MyHosting
    {
        private NancyHost host;
        private string uri;

        public MyHosting() {
            uri = "http://localhost:8080";
            host = new NancyHost(new Uri(uri));
        }
        public MyHosting(ushort tcpPortNumber) {
            uri = "http://localhost:" + tcpPortNumber;
            host = new NancyHost(new Uri(uri));
        }

        public void StartHost()
        {
            host.Start();
            Console.WriteLine("Running on " + uri);
        }

        public void StopHost()
        {
            host?.Dispose();
        }
    }
}

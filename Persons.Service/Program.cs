using System;
using Topshelf;

namespace Persons.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var rc = HostFactory.Run(x =>                                  
            {
                x.Service<MyHostingService>(s =>                           
                {
                    s.ConstructUsing(name => new MyHostingService());      
                    s.WhenStarted(tc => tc.Start());                       
                    s.WhenStopped(tc => tc.Stop());                        
                });
                x.RunAsLocalSystem();                                      

                x.SetServiceName("MyHostRestApi");                                 
                x.SetDisplayName("My testing REST API host");                                 
                x.SetDescription("bla bla");                  
            });                                                             

            var exitCode = (int)Convert.ChangeType(rc, rc.GetTypeCode());
            Environment.ExitCode = exitCode;
        }

        //Service class
        class MyHostingService
        {
            MyHosting myHosting;
            public MyHostingService()
            {
                myHosting = new MyHosting(); //Default tcp port 8080
            }

            public void Start()
            {
                myHosting.StartHost();
            }
            public void Stop()
            {
                myHosting.StopHost();
            }
        }
    }
}

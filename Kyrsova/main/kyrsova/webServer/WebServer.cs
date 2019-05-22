using System;
using Nancy.Hosting.Self;

namespace Kyrsova.main.kyrsova.webServer {
    public class WebServer {
        public static void Start()
        {
            using (var host = new NancyHost(new Uri("http://127.0.0.1:1234")))
            {
                host.Start();
                while (true)
                {
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;
using Oasp4net.ServiceLayer.App_Start;

namespace Oasp4net.ServiceLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseAddress = "http://localhost:8081/";
            Console.WriteLine("Starting the OASP4Net Web Api service on address: " + baseAddress);

            // Start OWIN host 
            using (WebApp.Start<WebApiStartup>(url: baseAddress))
            {
                Console.ReadLine();
            }
        }
    }
}

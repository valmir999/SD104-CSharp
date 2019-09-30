//Create a new Project:

//MVC with Entity Framework project
//Create two tables(POCOs). Be creative.Each POCO needs to have 5 or 6 fields.
//Create the CRUD pages and add links to the _Layout.cshtml page to bring up the listing page (Index) for each of your entities.
//Create 4 or 5 entities for each POCO
//To submit upload a screen shot of the two Index pages.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace WebApp_MVC_Question1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Daily_Interview_Question_MakingChange
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            string exit = "";
            Random rnd = new Random();
            while (!exit.Equals("x"))
            {
                int intPrice = rnd.Next(1, 100);
                decimal price = (decimal)intPrice / 100.00M + rnd.Next(10);
                int tendered = rnd.Next((int)price + 1, (int)price + rnd.Next(5));
                string change = MakingChange(tendered - price);
                Console.WriteLine(change);
                Console.Write("Type x to stop ");
                exit = Console.ReadLine();
            }

        }
        static public string MakingChange(decimal p)
        {
            string[] bill = new string[9] { "ONE HUNDRED", "TWENTY", "TEN", "FIVE", "ONE", "QUARTER", "DIME", "NICKEL", "PENNY", };
 
            string changeDue = "Change due: ";

            if (p>1.00)
            {
                changeDue = "Change due: " + (p % );
            }

            switch (p)
            {
                case 1:
                    changeDue= "One";
                    break;
                case 2:
                    changeDue = "Two";
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }

            return changeDue;
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

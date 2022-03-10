using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var container = new List<container>()
            {
                new container(){from="usa",to="uk",distance=9560},
                new container(){from="india",to="usa",distance=12000},
                new container(){from="uk",to="india",distance=8000},
                new container(){from="usa",to="india",distance=12000},
                new container(){from="uk",to="usa",distance=9560},
                new container(){from="india",to="uk",distance=8000}
            };
            int oneday = 500;
            int oneKmCharge = 10;
            Console.WriteLine("Enter PortID");
            int pId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter From place: ");
            string fromplace = Console.ReadLine();
            Console.WriteLine("Enter Destination Place:");
            string toplace = Console.ReadLine();
            foreach(var item in container)
            {
                if((item.from).Equals(fromplace) && (item.to).Equals(toplace))
                {
                    Console.WriteLine(item.distance);
                    int days = item.distance / oneday;
                    Console.WriteLine("For " + item.from + " to " + item.to + " ");
                    Console.WriteLine("Number of Days: " + days);
                    int charge = item.distance * oneKmCharge;
                    Console.WriteLine("Charges of Transportation is " + charge + " RS.");
                }
            }
        }
    }
    public class container
    {
        public string from { get; set; }
        public string to { get; set; }
        public int distance { get; set; }



    }
}

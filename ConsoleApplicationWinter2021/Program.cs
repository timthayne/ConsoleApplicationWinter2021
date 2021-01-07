using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationWinter2021
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.
            var name = "Brother Thayne";
            var location = "Rexburg, ID";

            // 3.
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");

            // 4.
            var currentDate = DateTime.Now;
            Console.WriteLine("The current date is " + currentDate.ToString("d"));









            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}

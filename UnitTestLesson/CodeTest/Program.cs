using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            int timeOfDay = 21;
            // timeOfDay is more than or equal to 4 or less than or equal to 12
            //Greeting(timeOfDay);
            string greetings = Greeting(timeOfDay);
            Console.WriteLine(greetings);
        }

        // private static void Greeting(int timeOfDay)
        public static string Greeting(int timeOfDay)
        {
            string greeting;
            if (timeOfDay >= 5 && timeOfDay <= 12)
            {
                // Console.WriteLine("Good Morning");
                greeting = "Good Morning";
            }

            else if (timeOfDay >= 12 && timeOfDay <= 18)
            {
                //Console.WriteLine("Good Afternoon");
                greeting = "Good Afternoon";
            }

            else
            {
                //Console.WriteLine("Good Evening");
                greeting = "Good Evening";
            }
            return greeting;
        }
    }
}

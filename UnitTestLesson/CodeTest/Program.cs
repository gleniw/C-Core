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
            int ageOfViewer = 10;

            // timeOfDay is more than or equal to 4 or less than or equal to 12
            //Greeting(timeOfDay);
            string greetings = Greeting(timeOfDay);
            Console.WriteLine(greetings);

            // ageOfViewer
            string classifications = Classification(ageOfViewer);
            Console.WriteLine(classifications);
        }

        //public static string AvailableClassifications(int ageOfViewer)
        //{
        //    return Classification(ageOfViewer);
        //}

        //public static string Classification(int ageOfViewer)
        //{
        //    string result;
        //    if (ageOfViewer < 12)
        //    {
        //        result = "U, PG & 12 films are available.";
        //    }
        //    else if (ageOfViewer < 15)
        //    {
        //        result = "U, PG, 12 & 15 films are available.";
        //    }
        //    else
        //    {
        //        result = "All films are available.";
        //    }
        //    return result;
        //}

        public static string Classification(int ageOfViewer)
        {
            string result;
            if (ageOfViewer < 12)
            {
                result = "U, PG & 12 films are available.";
            }
            else if (ageOfViewer < 15)
            {
                result = "U, PG, 12 & 15 films are available.";
            }
            else
            {
                result = "All films are available.";
            }
            return result;
        }


        // private static void Greeting(int timeOfDay)
        public static string Greeting(int timeOfDay)
        {
            string greeting;
            if (timeOfDay >= 5 && timeOfDay < 12)
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

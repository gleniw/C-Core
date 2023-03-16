using System;

namespace ExceptionsLabExercises
{
    public class Program
    {
        #region Greeting Exercises
        static void Main(string[] args)
        {
            int timeOfDay = 0;

            string greetings = Greeting(timeOfDay);
            Console.WriteLine(greetings);

            try
            {
                Console.WriteLine("The time of the day for 11:00 is: " + Greeting(11));
                Console.WriteLine("The time of the day for 17:00 is " + Greeting(17));
                Console.WriteLine("The time of the day for 17:00 is " + Greeting(-10));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Invalid data, please try again");
                Console.WriteLine(e.Message);
            }
        }

        public static string Greeting(int timeOfDay)
        {
            if (timeOfDay < 0 || timeOfDay > 24)
            {
                throw new ArgumentOutOfRangeException("TimeOfDay " + timeOfDay + " " + "Allowed Range 1-24 (where 1 = 1:00AM and 24 = 00:00");
            }
            string greeting;
            if (timeOfDay >= 5 && timeOfDay < 12)
            {
                greeting = "Good Morning";
            }

            else if (timeOfDay >= 12 && timeOfDay <= 18)
            {
                greeting = "Good Afternoon";
            }

            else
            {
                greeting = "Good Evening";
            }
            return greeting;
        }
        #endregion
    }
}
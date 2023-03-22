using System;

namespace FizzBuzzApp
{
    public class Program
    {
        // OUTPUTS INT FROM /3 Fizz /5 Buzz, 3/&/5 FizzBuzz
        static void Main(string[] args)
        {
            
            int max = 30;
            for (int i = 1; i <= max; i++) Console.WriteLine($"{FizzBuzz(i)}");

        }

        public static string FizzBuzz(int number)
        {

            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
           
            else if (number % 5 == 0)
            {
                return "Buzz";
            }
            else if (number % 3 == 0)
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }

            //return number.ToString();
        }
    }
}
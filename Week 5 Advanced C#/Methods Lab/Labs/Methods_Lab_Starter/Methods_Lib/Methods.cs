using System;

namespace Methods_Lib
{
    public class Methods
    {
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {
            if (totalDays < 0)
            {
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            }
            else
            {
                var nWeeks = totalDays / 7;
                var nDays = totalDays % 7;
                return (nWeeks, nDays);
            }

        }

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            return num1 + num2;
        }

        public static (int squared,int cubed ,double squareRoot) PowersRoot (int inputNumber)
        {
            var snumber = inputNumber * inputNumber;
            var cnumber = inputNumber * inputNumber * inputNumber;
            var srnumber = Math.Sqrt(inputNumber);

            return (snumber, cnumber, Math.Round(srnumber, 3));
        }

    }


}

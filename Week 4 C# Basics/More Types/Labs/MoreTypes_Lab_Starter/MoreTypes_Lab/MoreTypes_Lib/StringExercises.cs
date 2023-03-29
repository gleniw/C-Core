using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            
            string newInput = input.Trim().ToUpper();
            
            for (int i = 0; i < num; i++)
            {
                newInput = newInput + i;
            }
            return ($"{newInput}");
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            var newString = String.Concat(number + " " + street + ", " + city + " " + postcode + ".");
            return newString;
            //throw new ArgumentException();
        }

        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(int score, int outOf)
        {
            double pValue = ((double)score*100) / outOf;
            var newString = $"You got {score} out of {outOf}: {pValue:0.#}%";
            return newString;
            //throw new ArgumentException();
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {
            int number;
            bool isTrue = int.TryParse(numString, out number);

            if (isTrue)
            { 
                return -999; 
            }
            else
            {
                return double.Parse(numString);
            }
            

        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int result1 = input.Length - input.Replace("A", "").Length;
            int result2 = input.Length - input.Replace("B", "").Length;
            int result3 = input.Length - input.Replace("C", "").Length;
            int result4 = input.Length - input.Replace("D", "").Length;

            return ($"A:{result1} B:{result2} C:{result3} D:{result4}");

            //throw new ArgumentException();
        }
    }
}

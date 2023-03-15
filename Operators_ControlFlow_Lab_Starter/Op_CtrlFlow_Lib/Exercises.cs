using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        /*
         The above says if num 1 modulo num2 == 0 is true, else num1 equals num2 is false  
         */

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {
            if(nums.Count == 0) return 0;

            int sum = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                sum = sum + nums[i];
            }
            return Convert.ToDouble(sum) / nums.Count;
        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            if (age >= 0 && age <= 4)
            {
                return "Free";
            }
            else if(age >= 5 && age <= 12)
            { 
                return "Child";
            }
            else if (age >= 13 && age <= 17)
            {
                return "Student";
            }
            else if (age >= 60)
            {
                return "OAP";
            }
            else if (age >= 18 && age <= 59)
            {
                return "Standard";
            }
            else
            {
                return "Out of Range";
            }
            //string ticketType = string.Empty;
            //return ticketType;
        }

        public static string Grade(int mark)
        {
            if (mark >= 100)
            {
                return "Pass with Distinction";
            }
            else if (mark >= 60 && mark <= 74)
            {
                return "Pass with Merit";
            }
            else if (mark >= 40 && mark <= 59)
            {
                return "Pass";
            }
            else if (mark >= 0 && mark <= 39)
            {
                return "Fail";
            }
            else 
            {
                return "Invalid Entry";
            }
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            
            switch (covidLevel)
            {
                case <= 20:
                    covidLevel =  4;
                    break;
                case <= 30:
                    covidLevel = 3;
                    break;
                case <= 50:
                    covidLevel = 2;
                    break;
                case <= 100:
                    covidLevel = 1;
                    break;
                case <= 200:
                    covidLevel = 0;
                    break;
                default:
                    covidLevel = 10;
                    break;
            }
            return covidLevel;
        }
    }
}

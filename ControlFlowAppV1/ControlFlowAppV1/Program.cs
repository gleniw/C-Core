using System.Security.Cryptography.X509Certificates;

namespace ControlFlowAppV1
{
    public class Program
    {
        #region Main
        static void Main(string[] args)
        {
            //LIST TO FIND NUMBERS IN LOOP TYPES

            //List<int> nums = new List<int> { 10,6,22,-17,5};
            ////CORRECT
            //Console.WriteLine("Highest foreach loop " + LoopTypes.HighestForEachLoop(nums));
            ////CORRECT
            //Console.WriteLine("Highest for loop " + LoopTypes.HighestForLoop(nums));
            ////CORRECT
            //Console.WriteLine("Highest while loop " + LoopTypes.HighestWhileLoop(nums));
            ////CORRECT
            //Console.WriteLine("Highest do while loop " + LoopTypes.HighestDoWhileLoop(nums));

            //Console.WriteLine();

            //var message = Priority(2);
            //Console.WriteLine(message);

            ////Conditional Operators
            //int mark = 35;
            //var grade = mark >= 65 ? "Pass" : "Fail";

            //// In this example 65 is the statement - 1st evaluation "true" - 2nd evaluation "false"
            //// Both evaluations need to be the same data type

            //Chain CO - 2 instead of 1 - Brackets evaluated 1st IF / IF ELSE

            //int mark = 85;
            //var grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";

            //EXCEPTIONS
            try
            {
                Console.WriteLine("Sam's mark is 82: " + Grade(82));
                Console.WriteLine("Alex's mark is -23: " + Grade(-23));
            }
            catch (ArgumentOutOfRangeException e)
            {
                //Console.WriteLine("Invalid data, please try again");
                Console.WriteLine(e.Message); //Throw from Line 66
            }

        }
        #endregion

        ////Refactored version of above

        //public static string Grade(int mark)
        //{
        //    return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        //}

        //EXCEPTIONS

        public static string Grade(int mark)
        {
            if (mark < 0 || mark > 100)
            {
                throw new ArgumentOutOfRangeException("Mark " + mark + " " + "Allowed Range 0-100"); //throw an exception to send a message if error occurs
            }

            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }

        //public static string Priority(int level)
        //{
        //    string priority = "Code ";
        //    switch (level)
        //    {
        //        case 3:
        //            priority = priority + "Red";
        //            break;
        //        case 2:
        //            priority = priority + "Blue";
        //            break;
        //        case 1:
        //            priority = priority + "Amber";
        //            break;
        //        case 0:
        //            priority = priority + "Green";
        //            break;
        //        default:
        //            priority = "Error";
        //            break;
        //    }
        //    return priority;
        //}

    }

}
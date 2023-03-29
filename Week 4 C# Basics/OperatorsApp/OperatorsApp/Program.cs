namespace OperatorsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //#region Incrementor
            //int x = 1;
            //int a = x++; //increment by 1

            //int y = 1;
            //int b = ++y; //increment by 1

            ///*a increment after, b increment before*/
            ////only an issue if assigning to values i.e. ++i or i++ in below for loop is OK

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //#endregion

            //#region Intergar Division
            //var c = 5 / 2; //Divide 2 - Int will return Int 2 
            //var d = 5.0 / 2; //Double will return a double 2.5
            //var e = 5 / 3; //Int will return an Int 1

            //double f = 5 / 2; //Implicitly casted

            //#endregion

            //#region Modulus

            ///*if one number is devisable by another number*/

            //var daysInAWeek = 7;
            //var totalDaysToAlexsBirthday = 23;
            //var weeksToBirthday = totalDaysToAlexsBirthday/daysInAWeek;
            //var days = totalDaysToAlexsBirthday % daysInAWeek;
            //Console.WriteLine($"{weeksToBirthday}, {days}");
            //#endregion

            ////#region Assignment Operators
            ////int sum = 0;
            ////for (int i = 0;i <= 10;i++)
            ////{
            ////    sum = sum + i; //can change the assignment operators to */ etc. //these are assignment operators with added function
            ////    //sum += i;
            ////}
            ////Console.WriteLine(sum);
            ////#endregion

            // Logical Operators

            // & if both true it will be executed - evaluates both sides even if the first is false
            // && if both true it will be executed - only evaluates the right hand condition if left hand is true
            //Always use double ampersand and double pipe

            //bool isWearingParachute = false;
            //if (isWearingParachute && JumpOutOfAirplane())
            //{
            //    Console.WriteLine("Congrats, you have made a succesful jump");
            //}

            //else
            //{
            //    Console.WriteLine("Splat");
            //}

            //string greeting = null;
            //if (greeting != null && greeting.ToLower().StartsWith("a"))
            //{
            //    Console.WriteLine(greeting + " starts with 'a'");
            //}

            // Below to be completed

            int n = 5;
            int t = 3;

            if (n == 5 ^ t == 3)
            {
                Console.WriteLine("Print this");
            }
            
        }

        public static bool JumpOutOfAirplane()
        {
            Console.WriteLine("Jump");
            return true;
        }
    }
}

//BODMAS
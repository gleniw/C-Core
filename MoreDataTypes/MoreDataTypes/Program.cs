//using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace MoreDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////STRINGS ARE IMMUTABLE - ONCE CREATED THEY CANNOT BE CHANGED

            ////var myArr = new int[] {1,2,3,4};
            ////var name = "lucas";
            ////var lucasFirstName = name[0];
            ////myArr[1] = 1000;
            ////var myArrIndex1 = myArr[1];
            ////name[0] = "p";

            //////string is Alias for the String class i.e. it is an object but we declare it as a primative type

            ////string book = "Lord of the Rings";

            //////String Book = new String(book); // This is the same as the above

            //var myString = " C# list fundamentals ";
            //var result = StringBuilderExercise(myString);
            //Console.WriteLine(result);


            //String Interpolation

            //string firstName = "Cormac";
            //string lastName = "Chowdhury";
            //Console.WriteLine(firstName + " " + lastName); //concatenate

            //Console.WriteLine(String.Concat(firstName, " ", lastName)); //concatenate 
            //StringInterpolation(firstName, lastName);

            //var fString = $"{2} to the power of {7} is {Math.Pow(2, 7)}";

            //var fString2 = $"Log to the base {2} of {7} is {Math.Log(2, 7)}";
            //Console.WriteLine(fString2);


            //var fString2 = $"Log to the base {2} of {7} is {Math.Log(2, 7):0.####}"; //with rounding method
            //Console.WriteLine(fString2);

            //var fString3 = $"That will be {2.0/5:C}"; //Currency
            //Console.WriteLine(fString3);

            //var fString4 = $"That will be {2.0 / 5:P}"; //Percentage
            //Console.WriteLine(fString4);

            //Console.WriteLine("Enter a number "); //MUST BE AN INT // UNLESS OUTPUT VALUE IS DIFFERENT I.E. DOUBLE
            //var input = Console.ReadLine(); // READLINE ALWAYS READS A STRING
            //var inputParsed = Int32.Parse(input);
            //Console.WriteLine(inputParsed);

            //PARSE WITH WRONG ENTRY WILL THROW AN EXCEPTION

            //TRY PARSE WILL NOT THROW AN EXCEPTION


            //do
            //{
            //    Console.WriteLine("Please enter how many apples you want? ");
            //    var input = Console.ReadLine();
            //    bool isValidInput = Int32.TryParse(input,out int numApples ); //2 arguement //out return multiple values
            //    if (isValidInput) 
            //    {
            //        Console.WriteLine($"You asked for {input} apples");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter valid number");
            //    }
            //} 
            //while (true);

            //int[] myArr = new int[5];
            //myArr[0] = 1;
            //myArr[1] = 2;
            //myArr[2] = 3;
            //myArr[3] = 4;
            //myArr[4] = 5;
            //foreach (var item in myArr) 
            //{
            //    Console.WriteLine(item);
            //}

            //int[] myarr2 = new int[] { 1, 2, 3, 4, 5 };
            //foreach (var item in myArr)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] names = { "Lucas", "Glen", "Tasin" };
            ////names[3] = "Nish"; //throws an exception as index out of range
            ////foreach (var name in names)
            ////{
            ////    Console.WriteLine(name);
            ////}

            //Array.ForEach(names, x => Console.WriteLine(x)); // this is the same as the foreach loop above

            //int[] intArr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //{
            //    int sum = 0;
            //    foreach (var item in intArr) 
            //    { 
            //        sum = sum + item;
            //    }

            //    Console.WriteLine(sum);

            //    //Can use Int Array.Sum instead
            //}


            //// DATETIME CLASS

            //var now = DateTime.Now;
            //var mins = now.Minute;
            //var year = now.Year;
            //var ticks = now.Ticks;

            //var yearsPassed = DateTime.Now.Year - DateTime.MinValue.Year;
            //Console.WriteLine(yearsPassed);

            //var yearsUTC = DateTime.UtcNow;
            //Console.WriteLine(yearsUTC); // 32bit int - 2.4 billion // overflow will happen in 2038

            //// Ticks is a Long

            //DateTime tayloreSwiftsBirthday = new DateTime(1989, 12, 13);
            //TimeSpan tsAge = DateTime.Now - tayloreSwiftsBirthday;
            //var tsAgeInYears = tsAge.Days / 365.25;
            //Console.WriteLine(tsAgeInYears);


            ////CONST - IS A PRIVATE MEMBER VARIABLE
            ////UNIX TIME STARTS AT JAN 1ST 1970
            ////MICROSOFT TIME STARTS AT THE BEGININNG OF THE MONTH

            //Console.WriteLine(DateTime.Now.ToString("y-m-d"));
            //Console.WriteLine(DateTime.Now.ToString("dd-mm-yy"));

            //DateOnly birthday = new DateOnly(1989,11,2);
            //Console.WriteLine(birthday);

            ////Above inrtroducted in NET 6

            //Enum - Fixed set of constants 

            // DayOfWeek enum

            //Enums();

            //Enums and Switch generally go together

            //Suits theSuit = Suits.Hearts;

            //switch (theSuit)
            //{
            //    case Suits.Hearts:
            //        Console.WriteLine("Thanks");
            //        break;
            //    default:
            //        Console.WriteLine("cya");
            //        break;
            //}

            //int theSuitInt = (int)Suits.Hearts; //convert to Int using casting

            //Suits anotherSuit = 0;
            //Console.WriteLine(anotherSuit); // change a suit to another suit

            //BELOW NOT ON TEST

            var rng = new Random();
            //var rngSeeded = new Random(42);
            Console.WriteLine(rng.Next(1, 11));
            Console.WriteLine(rng.Next(1, 11));

        }

        public static void Enums()
        {
            Suits theSuit = Suits.Hearts;
            if (theSuit == Suits.Spades)
            {
                Console.WriteLine($"Suits is {Suits.Spades}");
            }
            else
            {
                Console.WriteLine($"the suit is {theSuit} not {Suits.Spades}");
            }
        }



        //STRING BUILDER REPRESENTS A MUTABLE STRING
        public static string StringBuilderExercise(string myString)
        {
            var trimmedUpperString = myString.Trim().ToUpper();
            var nPos = trimmedUpperString.IndexOf("N");
            StringBuilder sb = new StringBuilder(trimmedUpperString);
            sb.Replace("L", "*");
            sb.Replace("T", "*");
            sb.Remove(nPos + 1, sb.Length - nPos -1 ); //how much to delete after position of N
            return sb.ToString();
        }

        //strings that were returned
        //advantages are - string builder reduces objects and useful if doing a lot of string changes
        //string builder is big in itself and not all methods are possible

        public static string StringExercise(string myString)
        {
             myString = myString.Trim(); //Removes White Space
             myString = myString.ToUpper(); // Upper Case

            // REPLACE ALL L & T

            myString = myString.Replace("l", "t");
            // FIND INDEX OF LETTER N

            //// DELETE N AND ALL CHAR AFTER
            myString = myString.Remove(myString.IndexOf('N'));

            return myString;

        }

        public static void StringInterpolation (string fName, string lName)
        {
            ///Dollar indicated string interpolation
            ///Interpolated expression
            Console.WriteLine($"My name is: {fName} {lName}");
        }



    }
}
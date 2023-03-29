using System.ComponentModel;
using System.Diagnostics.SymbolStore;
using System.Runtime.Versioning;

namespace MethodsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Static
            //int sum = Calculator.Add(1, 2);

            //Non-Static
            //Calculator calculator = new Calculator();
            //int sumAlt = calculator.Addition(1, 2);

            //STATIC CLASS SUCH AS ARRAY - USES METHODS THAT DO NOT NEED A INSTANCE TO BE INSTANTIATED

            //var result = DoThis(10, 10, "Sad");
            //var result2 = DoThis(10, 10);

            //string pizza = OrderPizza(true, false);
            //string pizza = OrderPizza(pineapple: true, chicken: false, tuna: true, stuffed: true);
            //Console.WriteLine(pizza);

            //METHODS ONLY RETURN ONE TYPE

            //TUPLES CAN BE USED TO RETURN UNRELATED DATA TOGETHER

            ////DIFFERENT WAYS TO DECLARE A TUPLE
            //var myTuple = ("Lucas", "Adam", 45);
            //(string, string, int) myTuple2 = ("Lucas", "Adam", 45);
            //(string fName, string lName, int age) myTuple3 = ("Lucas", "Adam", 45);
            //var myTuple4 = (fName: "Lucas", lName:"Adam", age:45);

            //Console.WriteLine(myTuple);
            //Console.WriteLine(myTuple2);
            //Console.WriteLine(myTuple3);
            //Console.WriteLine(myTuple4);
            //Console.WriteLine(myTuple4.fName);
            //Console.WriteLine(myTuple.Item1);

            //string title = "Shrek";
            //double boxOffice = 1_000_000_000;
            //var film = (title, boxOffice);
            //Console.WriteLine(film);
            //Console.WriteLine(film.title);
            //Console.WriteLine(film.boxOffice);

            //var result = ConvertPoundsToStones(89);
            //Console.WriteLine(result);

            //bool isLarge = false;
            //var result = DoThis(10, "Here is a string", /*out*/ isLarge);

            int number = 10;
            Add(10);
            Console.WriteLine(number);
            Add(ref number);
            Console.WriteLine(number);

        }

        //Method Overloading - same signature, different type of parameter types 

        //Ref and Out not to really be used but need to be understood

        //Passing but value
        public static void Add(int num)
        {
            num++;
        }
        //Passing by Reference
        public static void Add(ref int num)
        {
            num++;
        }

        //TUPLE AS A RETURN TYPE

        public static int DoThis(int x,string y, /*out*/ bool z) //We pass the memory location of Z. Don't use out unless it can't be done another way
        {
            Console.WriteLine(y);
            z = (x > 10);
            return x * x;
        }

        public static (int st, int lbs ) ConvertPoundsToStones(int pounds)
        {
            const int poundsInAStone = 14;
            var st = pounds / poundsInAStone;
            var lbs = pounds % poundsInAStone;
            return (st, lbs);
        }

        public static string OrderPizza(bool tuna, bool chicken, bool stuffed, bool pineapple = false)
        {
            string pizza = "Pizza with tomato sauce, cheese ";
            if (tuna) pizza += ", tuna";
            if (chicken) pizza += ", chicken";
            if (pineapple) pizza += ", pineapple";
            pizza = stuffed ? pizza.Insert(0, "Stuffed Crust ") : "";
            return pizza.Remove(pizza.Length - 2, 1);
        }

        public static int DoThis(int x, int z, string y = "Happy") //Default value can be assigned to method values - These most appear at the end or there will be a compiler error
        {

            Console.WriteLine($"I am feeling {y}");
            return x * z;
        }
    }

    public class Calculator
    {
        //STATIC BELOWS TO THE CLASS
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        // NON STATIC - WE NEED TO INSTANTIATE AN INSTANCE 
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
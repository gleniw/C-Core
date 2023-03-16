using System.Collections.Generic;
using System.Xml;

namespace NumericleDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anInt = 3;
            var vInt = 4;
            var v2Int = vInt;

            var name = "Nish";
            var isClean = true;
            var letter = 'p';
            var ulongnum = 52UL;

            //ulongnum Unsign Int cannot be negative - UL is a way to declare the type of number and there are many other options (see microsoft literature)

            var prices = new List<int>();

            //Use of var to shorten code - Only use var when stating the datatype later in the line

            //Signed is all value including positive
            //Unsigned is all but negative

            //sbyte small = 2;
            //byte uSmall = 4;
            //short n1 = -65;
            //ushort n2 = 65;
            //int n3 = 100_000;
            //uint n4 = 100_000; //underscore can be used to make the number more clear without effecting the value
            //long n6 = -5_000_000_000;
            //ulong n7 = 5_000_000_000;

            //var n1 = -65;
            //var n2 = 65;
            //var n3 = 100_000;
            //var n4 = 100_000; //underscore can be used to make the number more clear without effecting the value
            //var n5 = 4_000_000_000;
            //var n6 = -5_000_000_000;
            //var n7 = 5_000_000_000;

            // int can never be NULL

            // Floating point numbers = Floar, Double, Decimal

            ////Example 1
            //float sum = 0;
            //for (int i = 0; i < 100000; i++) 
            //{
            //    sum += 2 / 5.0f;
            //}
            //Console.WriteLine("2/5 added 100,000 time " + sum);
            //Console.WriteLine("2 / 5 muliplyed 100,000 " + 2 / 5.0f * 100_000);

            //var result = 5.50 / 5; //defaults to double
            //Console.WriteLine(result);

            //int int1 = 5;
            //uint uint1 = int1;

            //Cannot implictly convert above as the range is different i.e. if you would lose data you cannot do it

            //char myChar = 'c';
            ////int myInt = 21;

            //int charInt = myChar;

            // //assigning the value of c to charint (i.e. 99 ASCII value)


            // byte myByte = 1000;

            //Above will not let the above happen as byte highest value is 1000.

            //byte myByte = Byte.MaxValue;
            //Console.WriteLine("ByteMax " + myByte);
            //myByte += 1;
            //Console.WriteLine("ByteMax " + myByte);

            ////Above is an example of an overflow error

            //sbyte mySbyte = sbyte.MaxValue;
            //Console.WriteLine("ByteMax " + mySbyte);
            //mySbyte += 1;
            //Console.WriteLine("ByteMax " + mySbyte);


            //mySbyte = sbyte.MinValue;
            //Console.WriteLine("SbyteMax " + mySbyte);
            //mySbyte -= 1;
            //Console.WriteLine("SbyteMax " + mySbyte);

            //double x = 3.141592765359;
            //float y = (float)x;

            //The above will convert double to float 

            int numCows = 260;
            //uint countCows = (uint)numCows;
            //byte byteCows = (byte)numCows;

            //int bankBalance = -2;
            //uint posBalance =(uint)bankBalance;

            //ABOVE are examples of unsafe conversations and not accurate

            //CONVERT CLASS TO BE USED INSTEAD

            string stringCows = Convert.ToString(numCows);

            //Good Conversation

            //string stringCows = Convert.ToString(numCows, 2);

            ////Shows binary representation

            // Above Unchecked i.e. the complier didn't throw an error


            // Checked Conversation

            checked
            {

            }

            //To find an overflow you can include a checked block as below so an exception is thrown

            //Can check entire program by changing settings
        }
    }
}
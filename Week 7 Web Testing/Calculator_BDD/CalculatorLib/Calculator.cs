using System.Linq;
namespace CalculatorLib
{
    public class Calculator
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public IEnumerable<int> Numbers { get; set; }

        public int Add()
        {
            return Num1 + Num2;
        }

        public int Divide()
        {
            if (Num1 == 0 || Num2 == 0) throw new DivideByZeroException("Cannot Divide By Zero");
            return Num1 / Num2;
        }

        public int Multiply()
        {
            return Num1 * Num2;
        }

        public int Subtract()
        {
            return Num1 - Num2;
        }

        public int SumEvenNumbers(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0) // check if the number is even
                {
                    sum += number; // add the even number to the sum
                }
            }
            return sum;
        }
    }

    // BENEFITS 
    // Human readable tests
    // Keeps code dry - don't repeat yourself
    // Re-using of previous Gherkin steps i.e. add and subtract
}
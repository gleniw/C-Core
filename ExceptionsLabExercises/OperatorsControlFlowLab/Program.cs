namespace OperatorsControlFlowLab
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Weight in Stones " + Method.GetStones(156));
                Console.WriteLine("Weight in Stones " + Method.GetStones(90));

            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}
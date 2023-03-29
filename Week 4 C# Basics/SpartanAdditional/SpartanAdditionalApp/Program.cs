namespace SpartanAdditionalApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Spartan gsmith = new Spartan("Glen Smith", 36, "C# Test Automation", -10000);

            Console.WriteLine(gsmith.SpartanDetails());
        }
    }
}
namespace UnitTestExceptionsLabExercises
{
    public class Program
    {
        static void Main(string[] args)
        {
            int ageOfViewer = 0;

            string classifications = Classification(ageOfViewer);
            Console.WriteLine(classifications);

            try
            {
                Console.WriteLine("With the selected age " + Classification(10));
                Console.WriteLine("With the selected age " + Classification(14));
                Console.WriteLine("With the selected age " + Classification(20));
                //Console.WriteLine("With the selected age " + Classification(-10));
                //Console.WriteLine("With the selected age " + Classification(125));
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Invalid data, please try again");
                Console.WriteLine(e.Message);
            }
        }
        public static string Classification(int ageOfViewer)
        {
            string result;
            if (ageOfViewer < 0 || ageOfViewer > 120)
            {
                throw new ArgumentOutOfRangeException("Age of Viewer " + ageOfViewer + " " + "Allowed Range 0-120");
            }
            if (ageOfViewer < 12)
            {
                result = "U, PG & 12 films are available.";
            }
            else if (ageOfViewer < 15)
            {
                result = "U, PG, 12 & 15 films are available.";
            }
            else
            {
                result = "all films are available.";
            }
            return result;
        }
    }
}
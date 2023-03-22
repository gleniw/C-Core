namespace SafariParkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Create and assign together
            Person alex = new Person("Alexander", "Blunt");

            //Below calls the set method of the Person object above
            alex.Age = 23;

            
            Console.WriteLine(alex.GetFullName());
            
            //Declaring nish and assigning a person
            Person nish;
            nish = new Person("Nish", "Mandal") { Age = 33 }; /*Object initilisers*/

            //Access age of Nish - Calls get Method
            var nishAge = nish.Age;
            Console.WriteLine(nishAge);

            nish.Age = -25;

        }
    }
}
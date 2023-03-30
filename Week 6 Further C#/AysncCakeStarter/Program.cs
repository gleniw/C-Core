using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AysncCake
{
    class Program

    {

        //Commenting out sections are option 1 to await sections until they are required
        //Current program with result means it does not continue through main method

        ////Async filters up, needs to awaited in each method that is called

        public async static Task Main(string[] args)
        {
            Console.WriteLine("Welcome to my birthday party");
            await HaveAPartyAsync(); //Await always has to return a task
            Console.WriteLine("Thanks for a lovely party");
            Console.ReadLine();
        }

        //Async filters up, needs to awaited in each method that is called
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Welcome to my birthday party");
        //    HaveAParty();
        //    Console.WriteLine("Thanks for a lovely party");
        //    Console.ReadLine();

        //    //Task<String[]> linesTask = File.ReadAllLinesAsync("myInput.txt"); // LOOK UP THIS FROM RECORDING - ASP.NET FRAMEWORK
        //}



        private async static Task HaveAPartyAsync() //Can be void if not returning a task
        {
            var name = "Cathy";
            //var clownTask = AwaitingClownAsync();
            //var bathroomTask = BathroomBreakAsync();
            var cakeTask = BakeCakeAsync();
            PlayPartyGames();
            OpenPresents();
            var cake = await cakeTask;
            //await bathroomTask;
            //await clownTask;
            Console.WriteLine($"Happy birthday, {name}, {cake}!!");
        }

        //private static void HaveAParty() //Can be void if not returning a task
        //{
        //    var name = "Cathy";
        //    var cakeTask = BakeCakeAsync(); //returns a task, not a cake itself
        //    PlayPartyGames();
        //    OpenPresents();
        //    var cake = cakeTask.Result; //waits here until BakeACakeAsync returns, without returning to the calling method
        //    Console.WriteLine($"Happy birthday, {name}, {cake}!!");
        //}

        private async static Task<Cake> BakeCakeAsync() //Make Async - i.e. Aysnc method and return type / Task / Convention Async suffix to Bake Cake
        {
            Console.WriteLine("Cake is in the oven");
            await Task.Delay(TimeSpan.FromSeconds(5)); //Will do task in background but still continue on 
            //Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine("Cake is done");
            return new Cake();
        }

        //private async static Task<Cake> BakeCakeAsync() //Make Async - i.e. Aysnc method and return type / Task / Convention Async suffix to Bake Cake
        //{
        //    Console.WriteLine("Cake is in the oven");
        //    await Task.Delay(TimeSpan.FromSeconds(5)); //Will do task in background but still continue on 
        //    //Thread.Sleep(TimeSpan.FromSeconds(5));
        //    Console.WriteLine("Cake is done");
        //    return new Cake();
        //}

        //Below is additional added by Glen for task
        //private async static Task<Clown> AwaitingClownAsync()
        //{
        //    Console.WriteLine("Awaiting arrival of the Clown");
        //    await Task.Delay(TimeSpan.FromSeconds(5));
        //    Console.WriteLine("The clown performs his act");
        //    return new Clown();
        //}

        //private async static Task<Person> BathroomBreakAsync()
        //{
        //    var nish = new Person("Nish", "Mandal");
        //    Console.WriteLine($"{nish} Goes to the Bathroom");
        //    await Task.Delay(TimeSpan.FromSeconds(5));
        //    Console.WriteLine($"{nish} returns from Bathroom");
        //    return new Person();
        //}

        private static void PlayPartyGames()
        {
            Console.WriteLine("Starting games");
            Thread.Sleep(TimeSpan.FromSeconds(2));
            Console.WriteLine("Finishing Games");
        }

        private static void OpenPresents()
        {
            Console.WriteLine("Opening Presents");
            Thread.Sleep(TimeSpan.FromSeconds(1));
            Console.WriteLine("Finished Opening Presents");
        }
    }

    public class Cake
    {
        public override string ToString()
        {
            return "Here's a cake";
        }
    }

    public class Clown
    {
        public override string ToString()
        {
            return "The clown performs";
        }
    }
    //Below is additional added by Glen for task
    //public class Person
    //{

    //    private string _firstName = "";
    //    private string _lastName = "";


    //    public Person()
    //    {

    //    }

    //    public Person(string fName, string lName)
    //    {
    //        _firstName = fName;
    //        _lastName = lName;

    //    }
    //    public override string ToString()
    //    {
    //        return $"{_firstName} {_lastName}";
    //    }
    //}
}

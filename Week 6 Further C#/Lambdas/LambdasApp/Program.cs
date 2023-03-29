using System.Linq;

namespace LambdasApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region
            Console.WriteLine("\nLanguage Integrated Query");
            //Syntax to mimic querying of a database

            var nums = new List<int> { 3, 7, 1, 2, 8, 3, 0, 4, 5 };

            Console.WriteLine("Count All");
            int allCount = nums.Count(); // Count number of items in list
            Console.WriteLine(allCount);

            Console.WriteLine("\nCount Even");

            int countEven = 0;
            foreach (var n in nums)
            {
                if (IsEven(n)) countEven++; // selected logic i.e. n % 2 == 0 with quick actions to extract method
            }
            Console.WriteLine(countEven);
            //Count even is 4

            //Below does the same as above
            int linqCount = nums.Count(IsEven); //Can add method into nums.Count to call it
            Console.WriteLine(linqCount);

            Console.WriteLine("\nObject Count");

            var people = new List<Person>
            {
                new Person {Name = "Cormac", Age = 40, City = "Wexford"},
                new Person {Name = "Tasin", Age = 55, City = "London"},
                new Person {Name = "Ali", Age = 20, City = "London"},
            };

            //Input is Person and Return Bool 
            //Everything in the list is acting as an argument

            var youngPeopleCount = people.Count(IsYoung);
            Console.WriteLine(youngPeopleCount);

            //Count isn't the only Linq method you can use for the above example

            //Use LAMBDA if method only needed once

            Console.WriteLine("\nDelegates"); // Old way to do things

            var evenCount2 = nums.Count(delegate (int n) { return n % 2 == 0; }); //Takes in and method curly braces

            Console.WriteLine(evenCount2);

            Console.WriteLine("\nLAMBDA");

            // Given this => return this

            var evenLambdaCount = nums.Count(n => n % 2 == 0);
            // n is not declared outside of the expression 
            // Type is inferred by the .Count type 
            Console.WriteLine(evenLambdaCount);

            Console.WriteLine("\nPeople Count with LAMBDA");
            var peopleCount = people.Count();
            Console.WriteLine(peopleCount);

            var youngPeopleCount2 = people.Count(p => p.Age < 30);
            Console.WriteLine(youngPeopleCount2);

            var totalAge = people.Sum(p => p.Age);
            Console.WriteLine(totalAge);

            int oldPeopleTotalAge = people.Sum(p => p.Age >= 30 ? p.Age : 0); // Checking if Person is greater or equal than Age and returning true or false
            Console.WriteLine(oldPeopleTotalAge);

            Console.WriteLine("\nLINQ QUERY");

            var peopleLondonQuery = people.Where(c => c.City == "London"); // Check result of CW // We need a foreach to iterate over
            foreach (var person in peopleLondonQuery)
            {
                Console.WriteLine(person);
            }
            //Here we are returning people that live in London (full object details i.e. including Age)
            //Console.WriteLine(peopleLondonQuery);

            Console.WriteLine("\nPeople Order by Age LAMBDA");

            var peopleOrderByAgeQuery = people.OrderBy(x => x.Age);
            foreach (var person in peopleOrderByAgeQuery)
            {
                Console.WriteLine(person);
            }

            //Order by with a Public Property

            Console.WriteLine("\nUsing Select to return a particular property within class");

            var peopleOver20Query = people.Where(c => c.Age > 20).Select(p => p.Name);

            foreach (var p in peopleOver20Query)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nReturn Array through Query");
            var peopleOver20Array = peopleOver20Query.ToArray();
            foreach (var p in peopleOver20Array)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine("\nCreate List, Create Query, Execute Query");

            var peopleLondonList = people.Where(p => p.City == "London").ToList(); //Create list, Create Query, Execute Query
            foreach (var p in peopleLondonList)
            {
                Console.WriteLine(p);
            }

            //Other queries Max
            #endregion

        }

        //Expression body syntax below - LAMBDA METHOD
        public static int Square(int x) => x * x; 

        //public static int Square(int x)
        //{
        //    return x * x;
        //}

        public static bool IsYoung(Person person)
        {
            return person.Age < 30;
        }

        private static bool IsEven(int n)
        {
            return n % 2 == 0;
        }
    }

    public class Person

    {
        private int _age;
        public string Name { get; set; }

        //Below is example of Get / Set in LAMBDA / TERNERY EXPRESSION
        public int Age
        {
            get => _age;
            set => _age = value < 0 ? throw new ArgumentException() : value;
        }
        public string City { get; set; }
        public override string ToString()
        {
            return $"{Name} - {City} - {Age}";

        }
    }
}
using System.Linq;

namespace LambdaLab_Lib
{
    public class Exercsises
    {
        public static int CountTotalNumberOfSpartans(List<Spartan> spartans)
        {
            return spartans.Count();
        }

        public static int CountTotalNumberOfSpartansInUKAndUSA(List<Spartan> spartans)
        {
            return spartans.Count(p => p.Country == "U.K." || p.Country == "U.S.A.");
            
        }

        public static int NumberOfSpartansBornAfter1980(List<Spartan> spartans)
        {
            return spartans.Count(p => p.DateOfBirth.Year >= 1980);
        }

        public static double SumOfAllSpartaMarksMoreThan50Inclusive(List<Spartan> spartans)
        {
            return spartans.Sum(p => p.SpartaMark >=50 ? p.SpartaMark : 0);
        }

        //To 2 decimal points
        public static double AverageSpartanMark(List<Spartan> spartans)
        {
            double average;
            average = spartans.Sum(p => p.SpartaMark) / spartans.Count();
            return Math.Round(average, 2);
        }

        public static List<Spartan> SortByAlphabeticallyByLastName(List<Spartan> spartans)
        {

            return spartans.OrderBy(p => p.LastName).ToList();
             
        }

        public static List<string> ListAllDistinctCities(List<Spartan> spartans)
        {
            return spartans.Select(c => c.City).Distinct().ToList();
            throw new NotImplementedException();
        }

        public static List<Spartan> ListAllSpartansWithIdBeginingWithB(List<Spartan> spartans)
        {
            return spartans.Where(c => c.SpartanId.StartsWith("B")).ToList();
        }
    }
}
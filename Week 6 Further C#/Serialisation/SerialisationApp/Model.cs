using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SerialisationApp
{
    [Serializable]
    public class Trainee
    {
        public string? FirstName { get; init; } 
        
        // ? makes value nullable - good way to make it clear that int cannot be default i.e. 0
        public string? LastName { get; init; }

        public int? SpartaNo { get; init; }

        //[JsonIgnore] // ignores the below when output to Json
        //public string FullName => $"{FirstName} {LastName}"; //Property - Get with no Set

        //If the below string adds ? it will be against Liskov Substitution Priciple
        //as Null is being returned rather than String
        public override string ToString()
        {
            return $"{SpartaNo} {FirstName} {LastName} "; //- {FullName}";
        }

    }

    [Serializable]

    public class Course
    {
        public string Subject { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public List<Trainee> Trainees { get; } = new List<Trainee>(); //Always initialise
        
        [field: NonSerialized]
        private readonly DateTime _lastRead;

        public Course()
        {
            _lastRead = DateTime.Now;
        }

        public void AddTrainee(Trainee newTrainee)
        {
            Trainees.Add(newTrainee);
        }
    }
}

namespace SerialisationApp
{
    public class Program
    {
        static ISerialise _serialiser;
        static string _path;
        static void Main(string[] args)
        {
            #region Null Types
            //int? a;
            //bool? b;
            //int c;
            //bool d;
            //string? e;
            //string f;

            ////Above example of null values and use of ?
            #endregion

            #region XML

            //Turning classes and temporary parts of the program into
            //something that can be stored on harddrive to be used again

            Console.WriteLine("Trainee");
            var trainee = new Trainee { FirstName = "Ali", LastName = "Cemgiz", SpartaNo = 100 };
            //Initialised as no Constructor
            //Console.WriteLine(trainee);

            //Arguments to the Command Line - Static Fields above

            _path = @"C:\Users\Glen Smith\C-Core\Week 6 Further C#\Serialisation";
            //Keeping it in the repository i.e. where file we be created 

            //_serialiser = new SerialiserXML();
            //_serialiser.SerialiseToFile($"{_path}/XMLTrainee.xml", trainee);

            //Trainee deserialisedXMLTrainee = _serialiser.DeserialiseFromFile<Trainee>($"{_path}/XMLTrainee.xml");


            Course tech206 = new Course { Title = "Tech206", Subject = "C# TAE", StartDate = new DateTime(2023, 2, 20) };

            tech206.AddTrainee(trainee);
            tech206.AddTrainee(new Trainee { FirstName = "Cormac", LastName = "Porter", SpartaNo = 101 });
            //_serialiser.SerialiseToFile($"{_path}/XMLCourse.xml", tech206);


            //var editedCourse = _serialiser.DeserialiseFromFile<Course>($"{_path}/XMLCourseEdited.xml");

            #endregion

            #region JSON

            //_serialiser = new SerialiserJson();
            //_serialiser.SerialiseToFile($"{_path}/JsonTrainee.xml", trainee);
            //Trainee deserialisedJsonTrainee = _serialiser.DeserialiseFromFile<Trainee>($"{_path}/JsonTrainee.xml");
            //_serialiser.SerialiseToFile($"{_path}/JsonCourse.xml", tech206);

            #endregion

            #region YAML

            //Serialise
            _serialiser = new SerialiserYAML();
            _serialiser.SerialiseToFile($"{_path}/YamlTrainee.xml", trainee);
            _serialiser.SerialiseToFile($"{_path}/YamlCourse.xml", tech206);

            //Deserialise
            Trainee deserialisedYamlTrainee = _serialiser.DeserialiseFromFile<Trainee>($"{_path}/YamlTrainee.xml");

            Trainee deserialisedYamlCourse = _serialiser.DeserialiseFromFile<Trainee>($"{_path}/YamlCourse.xml");

            #endregion
        }
    }
}
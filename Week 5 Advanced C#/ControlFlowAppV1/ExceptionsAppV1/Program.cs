namespace ExceptionsAppV1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string text;
            string filename = "HelloWorld.txt";
                
            try // trying the process // will only jump to catch block if error is caught
            {
                text = File.ReadAllText(filename);
                Console.WriteLine(text);
            }
            catch(FileNotFoundException e) //Catching a runtime error - e is naming the error
            {
                Console.WriteLine("Sorry I can't find " + filename);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("You gave me an empty file name");
            }
            finally //once complete pass/fail - do this
            {
                Console.WriteLine("Finished");
            }

            //var text = File.ReadAllText(HelloWorld.txt); //EXCEPTION AS FILE DOES NOT EXIST
        }
    }
}

//TYPE OF EXCEPTIONS - ALWAYS AT RUNTIME
//INDEX OUT OF RANGE
//DIVIDED BY ZERO
//SYNTAX ERROR - CODE LANGUAGE ERROR
//LOGIC ERROR - COMPILE BUT NOT CORRECT RESULT
//WE SHOULD BE TESTING FOR EXCEPTIONS
// TRY CATCH - PROVIDE OWN ERROR MESSAGE RATHER THAN BREAK
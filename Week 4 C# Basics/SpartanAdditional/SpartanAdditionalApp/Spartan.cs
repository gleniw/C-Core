using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpartanAdditionalApp
{
    public class Spartan
    {
        //Fields
        private string _fullName;
        private int _age;
        private int _spartanScore;

        //Properties
        public string Fullname { get; set; }
        public string Stream { get; set; }
        public int SpartanScore 
        {
            get { return _spartanScore; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    _spartanScore = value;
                }
            }
        }

        //Constructor
        public Spartan(string fullName, int age, string stream, int spartanScore)
        {
            this._fullName = fullName;
            this._age = age;
            Stream = stream;
            SpartanScore = spartanScore;
        }

        public string SpartanDetails()
        {
            return $"{_fullName} {_age} {Stream} {SpartanScore}";
        }
    }
}

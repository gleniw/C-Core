using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Person
    {
        //Variables

        private string _firstName;
        private string _lastName;

        //Below is auto property
        //public int Age {get; set;}

        //Long version of above auto property
        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                //_age = value < 0 ? throw new ArgumentException("Age cannot be less than 0") : value;
                //age = if value less than 0 throw exception

                if (value < 0)
                {
                    throw new ArgumentException("Age cannot be less than 0");
                }
                else
                {
                    _age = value;
                }
            }
        }

        //PROPFILL to make above method in long hand 

        //Constructor - same name as class and is used to construct the object. No return type.
        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

    }
}

//Different coding standards
//Microsoft standards we will follow
//Camel case for variables
//Pascal case for most others
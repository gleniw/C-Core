using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Address
    {

        public int HouseNumber { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }

        public Address(int houseNo, string street, string town)
        {
            HouseNumber = houseNo;
            Street = street;
            Town = town;

        }

        public string GetAddress()
        {
            return $"{HouseNumber},{Street} {Town} " ;
        }
    }
}

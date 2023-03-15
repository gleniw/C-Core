using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsApp
{
    public class Method
    {
        public static int GetStones(int totalPounds)
        {

            int totalStones = totalPounds / 14;
            return totalStones;

        }

        public static int GetPounds(int totalPounds) 
        {
            totalPounds = totalPounds % 14;
            return totalPounds;

        }
    }
}

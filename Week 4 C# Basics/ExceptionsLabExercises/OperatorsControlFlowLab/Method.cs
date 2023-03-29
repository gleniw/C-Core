using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsControlFlowLab
{
    public class Method
    {
        public static int GetStones(int totalPounds)
        {
            if (totalPounds < 0)
            {
                throw new ArgumentOutOfRangeException("Weight " + totalPounds + " " + "Cannot enter a negative value");
            }
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

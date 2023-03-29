using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlowAppV1
{
    public static class LoopTypes

    {

        internal static int HighestForEachLoop(List<int> nums)
        {
            //int highest = nums[0]; 
            
            //// For List with Negative Numbers - nums[0] to make it relevent for starting postition. This would not work with an empty array
            
            ///int highest = Int32.MinValue;
            
            ////Both highest options do the same thing

            int highest = 0;

            foreach (int i in nums)
            {
                if (i > highest) highest = i;
            }
            return highest;
        }

        internal static int HighestForLoop(List<int> nums)
        {
            int highest = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
            }

            return highest;
        }
        internal static int HighestWhileLoop(List<int> nums)
        {
            int highest = 0;
            int i = 0;
            while (i < nums.Count)
            {
                if (nums[i] > highest)
                {
                    highest = nums[i];
                }
                i++;
            }
            return highest;
        }

        internal static int HighestDoWhileLoop(List<int> nums)
        {
            int highest = 0;
            int counter = 0;
            do
            {
                if (nums[counter] > highest)
                {
                    highest = nums[counter];
                }
                counter++;

            } while (counter < nums.Count);

            return highest;
        }
        
        ///Different loops for different purposes
    }
}

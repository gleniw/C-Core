using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            var makeFiveList = new List<int>();

            for (int i = 1; i <= max; i++)
            {
                if (i % 5 == 0)
                    makeFiveList.Add(i);
            }
            return makeFiveList;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            var makeAList = new List<String>();

            foreach (string sourceString in sourceList)
            {
                if (sourceString.StartsWith("A") || sourceString.StartsWith("a"))
                makeAList.Add(sourceString);
            }
            return makeAList;
        }
    }
}

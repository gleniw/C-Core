using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            var nextInQueue = new Queue<string>();

            //if (queue.Count == num)
            //{

            //}

            if (queue.Count > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    nextInQueue.Enqueue(queue.Dequeue());
                }
            }

            return $"{nextInQueue}";
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            int [] reversed = new int[original.Length];

            var newStack = new Stack<int>();
            foreach (int i in original)
            {
                newStack.Push(i);
            }
            for (int i = 0; i < original.Length; i++)
            {
                reversed[i] = newStack.Pop();
            }
            return reversed;

        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            input = input.Trim();

            var countDict = new Dictionary<char, int>();

            string dictionaryString = "";

            foreach (var c in input)
            {
                if (char.IsDigit(c))
                {
                    if (countDict.ContainsKey(c))
                    {
                        countDict[c]++;

                    }
                    else
                    {
                        countDict.Add(c, 1);
                    }

                    foreach (KeyValuePair<char, int> keyValues in countDict)
                    {
                        dictionaryString += "[" + keyValues.Key + " ," + keyValues.Value + "]";
                    }

                }


            }

            return dictionaryString;
        }

    }
}

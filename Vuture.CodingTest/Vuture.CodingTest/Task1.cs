using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuture.CodingTest
{
    class Task1
    {
        //Create a function which counts the number of occurrences of a given letter in a string.
        public String occurrences(char letter, string sentence)
        {
            Console.WriteLine("Task 1: ");
            int times = sentence.Count(x => x == letter);
            if (times > 1)
            {
                return "The letter '" + letter + "' appears " + times
                    + " times in '" + sentence + "'";
            }
            else
            {
                return "The letter '" + letter + "' appears " + times
                    + " time in '" + sentence + "'";
            }
        }
        //
    }
}

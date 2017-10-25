using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vuture.CodingTest
{
    class Task2
    {
       // Create a function which decides if a string is a palindrome.
      public bool palindrome(string sentence)
        {
            Console.WriteLine("\nTask 2: ");
            Console.WriteLine("Deciding if '" + sentence + "' is a palindrome\n");
            sentence = Regex.Replace(sentence, "[^0-9A-Za-z]+", "");
            string reversedSentence = new string(sentence.Reverse().ToArray());

            if (String.Compare(sentence, reversedSentence, StringComparison.OrdinalIgnoreCase) == 0)
               return true;
            else
               return false;
        }
    }
}

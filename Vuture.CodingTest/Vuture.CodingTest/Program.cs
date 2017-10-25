using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vuture.CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1 task1 = new Task1();
            string occurrence = task1.occurrences('e', "hello");
            Console.WriteLine(occurrence);

            Task2 task2 = new Task2();
            bool palindrome = task2.palindrome("God saved Eva's dog");
            Console.WriteLine(palindrome);

            Task3 task3 = new Task3();
            String[] array = { "cat", "dog", "turtle" };
            string message1 = task3.censorWordCounter(array, "There is a cat, a dog");
            Console.WriteLine(message1);

            string message2 = task3.censorWord(array, "There is a cat and a dog");
            Console.WriteLine(message2);

            string message3 = task3.censorPalindromeWord("Anna went to vote in the election to fulfil her civic duty");
            Console.WriteLine(message3);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Vuture.CodingTest
{
    class Task3
    {
       // Task 3
       //Part A)
       //Create a function which counts the number of occurrences of words from a 
       //"censored words list" in a text.
       public string censorWordCounter(String[] array, string sentence)
        {
            Console.WriteLine("\nTask 3: ");
            Console.WriteLine("Part A: ");
            Console.WriteLine(sentence);
            string message = "";
            int arrayLenght = array.Length;
            int quantity = 0;
            int total = 0;
            for (int i=0; i < array.Length; i++)
            {
                quantity = Regex.Matches(Regex.Escape(sentence), array[i]).Count;
                total = quantity + total;
                message = message + " " + array[i] + ": " + quantity + ",";
            }
            message = message + " total: " + total;
            return message;
        }

        //Part B)
        //Create a way to censor words featured in the "censored words list" 
        //that appear in the text.
        public string censorWord(String[] array, string sentence)
        {
            Console.WriteLine("\nPart B: ");
            Console.WriteLine(sentence);
            int arrayLenght = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                
                string oldWord = array[i];
                int oldWordLength = oldWord.Length;
                string newWord = oldWord.Remove(1,oldWordLength-2);
                for(int j = 1; j<oldWordLength; j++)
                {
                    newWord = newWord.Insert(j, "$");
                }
                sentence = sentence.Replace(oldWord, newWord);
            }
            return sentence;
        }

        //Part C
        //Create a way to censor a single word palindrome in a text.
        public string censorPalindromeWord( string sentence)
        {
            Console.WriteLine("\nPart C: ");
            String[] array = sentence.Split(' ');
            Console.WriteLine(sentence);
            int arrayLenght = array.Length;
            String word;
            String reversedWord;
            for (int i = 0; i < array.Length; i++)
            {
                word = array[i];
                reversedWord = new string(word.Reverse().ToArray());
                if (String.Compare(word, reversedWord, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    string oldWord = array[i];
                    int oldWordLength = oldWord.Length;
                    string newWord = oldWord.Remove(1, oldWordLength - 2);
                    for (int j = 1; j < oldWordLength; j++)
                    {
                        newWord = newWord.Insert(j, "$");
                    }
                    sentence = sentence.Replace(oldWord, newWord);
                }
            }
            return sentence;
        }

        //Part D
        //1) Replace censored word with clean word: Every censored word will have
        //a matching a word that corresponds to the clean version. The program would
        //take two arrays (one for the censored words and one for the clean words) where
        //the position of an array would match for the censored and clean word and replace
        //the sentence including censored words with the clean words.
        //Example: {woof, dog}, {sound, animal} 
        //Input: "There was a dog, barking in the distance"
        //Output: "There was an animal, sounding in the distance"

        //2)Replace censored word with single word: Every censored word will be replaced
        //with the same word. The method will take a list of censored words and the desired
        //word for the replacement. The function will find the word according to the list
        //of input censored words and replace with with the input censoring word.
        //Input: {election, civil}, unknown 
        //"Anna went to vote in the election to fulfil her civic duty"
        //Output: "Anna went to vote in the unknown to fulfil her unknown duty"

        //3)Replace censored word with similar word but containing special characters:
        //The function will take a list of censored words as input and two lists where one
        //list contains letter and another list contains a special character whose resemblance
        //depicts the original letter. The function will match the censored word in the sentence
        //and replace original characters with special characters.

        //Example:
        //Input: {vote, election}, {o,e,i}, {0,3,1}
        //"Anna went to vote in the election to fulfil her civic duty"
        //Output: "Anna went to v0t3 in the 3lect10n to fulfil her civic duty"
    }
}

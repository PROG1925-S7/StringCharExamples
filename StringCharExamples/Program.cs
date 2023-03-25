/* StringCharExamples
 * 
 * To demonstrate the use of methods to manipulate strings and chars
 * 
 * Revision History
 *     Tony Theo.... 2023.03.25:  Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCharExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringAndChars();
            //SearchingStrings();
            //SubstringExamples();
            DelimsTokens();

            Console.ReadKey();
        }

        static void StringAndChars()
        {
            string testString = "Tony Theo";
            char letter;

            //1. Display a string one letter at a time
            for (int i = 0; i < testString.Length; i++)
            {
                Console.WriteLine($"{i}: {testString[i]}");
            }

            //2. Display only the user inputted letter in the string
            Console.Write("Please enter a letter: ");
            letter = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Only showing letter " + letter);

            for (int i = 0; i < testString.Length; i++)
            {
                if (testString[i] == letter)
                {
                    Console.WriteLine($"{i}: {testString[i]}");
                }
            }

            //3. Convert strings and chars to upper or lowercase
            Console.WriteLine();

            Console.WriteLine(testString.ToUpper());
            Console.WriteLine(testString);

            testString = testString.ToUpper();
            Console.WriteLine(testString);

            testString = testString.ToLower();
            Console.WriteLine(testString);

            Console.WriteLine(char.ToUpper(letter));
            Console.WriteLine(letter);

            letter = char.ToUpper(letter);
            Console.WriteLine(letter);

            letter = char.ToLower(letter);
            Console.WriteLine(letter);

            //4. Determine what 'type' a character is

            if (char.IsLetter(letter))
            {
                Console.WriteLine($"{letter} is a letter");
            }
            else
            {
                Console.WriteLine($"{letter} is a not a letter");
            }

            if (char.IsDigit(letter))
            {
                Console.WriteLine($"{letter} is a number");
            }
            else
            {
                Console.WriteLine($"{letter} is a not a number");
            }

            if (char.IsPunctuation(letter))
            {
                Console.WriteLine($"{letter} is punctuation");
            }
            else
            {
                Console.WriteLine($"{letter} is a not punctuation");
            }

        }

        static void SearchingStrings()
        {
            string testString, substringValue;
            int index;

            //1. Search for a string inside another string

            Console.WriteLine("Enter your class code: ");
            testString = Console.ReadLine();

            if (testString.Contains("PROG"))
            {
                Console.WriteLine("This is a programming class");
            }
            else
            {
                Console.WriteLine("This is not a programming class");
            }

            //2. Find where a character is in a string
            index = testString.IndexOf("P");

            Console.WriteLine(index);

            if (index >= 0 )
            {
                Console.WriteLine($"character P was at index {index}");
            }
            else
            {
                Console.WriteLine("Character not found");
            }

            //3. Find where a string is in a string
            testString = "xx oo xx oo";
            substringValue = "xx";

            index = testString.IndexOf(substringValue);
            Console.WriteLine(index);

            index = testString.IndexOf("xx", index + substringValue.Length);
            Console.WriteLine(index);

        }

        static void SubstringExamples()
        {
            string testString = "New York";
            string substringValue;

            //1. Insert a string into a string
            testString = testString.Insert(3, "ish");
            Console.WriteLine(testString);

            //2. Remove a string from a string
            testString = testString.Remove(0, 7); 
            Console.WriteLine(testString);

            //3. Get a part of a string, (a substring), from a string
            testString = "Conestoga College Waterloo";
            substringValue = testString.Substring(18, 8);
            substringValue = testString.Substring(testString.LastIndexOf(" ")+1);


            Console.WriteLine(testString);
            Console.WriteLine(substringValue);
 
        }

        static void DelimsTokens()
        {
            string testString = "tony,ari,angela";
            string[] tokens;

            tokens = testString.Split(',');

            foreach (string s in tokens)
            {
                Console.WriteLine(s);
            }

            testString = "Toronto Maple Leafs";

            tokens = testString.Split(' ');

            foreach (string s in tokens)
            {
                Console.WriteLine(s);
            }

            testString = "tony ari,angela:john";

            tokens = testString.Split(' ', ',', ':');

            foreach (string s in tokens)
            {
                Console.WriteLine(s);
            }

            for(int i = 0; i< tokens.Length; i++) 
            {
                tokens[i] = char.ToUpper(tokens[i][0]) + tokens[i].Substring(1);
            }

            foreach (string s in tokens)
            {
                Console.WriteLine(s);
            }
        }
    }
}

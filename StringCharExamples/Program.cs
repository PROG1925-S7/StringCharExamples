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
            StringAndChars();

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
    }
}

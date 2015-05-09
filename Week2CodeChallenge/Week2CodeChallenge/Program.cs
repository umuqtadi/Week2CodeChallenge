using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 21; i++)
            {
                FizzBuzz(i);
            }

            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down");
            LetterCounter('s', "Sally sells sea shells by the seashore. She's from sussex.");

            Console.ReadKey();
        }

        static void FizzBuzz(int number)
        {
            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        static void LetterCounter(char letter, string inString)
        {
            int numLower = 0;
            int numUpper = 0;

            for (int i = 0; i < inString.Length; i++)
            {
                if (letter.ToString().ToLower().Contains(inString[i].ToString()))
                {
                    numLower++;
                }
                if (letter.ToString().ToUpper().Contains(inString[i].ToString()))
                {
                    numUpper++;
                }
            }
            Console.WriteLine("Input: " + inString);
            Console.WriteLine("Number of lowercase letters: {0}", numLower);
            Console.WriteLine("Number of uppercase letters: {0}", numUpper);
            Console.WriteLine("Total letters found: " + (numUpper + numLower));
        }
    }
}

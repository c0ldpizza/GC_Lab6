//author: Charlie Lambrecht
//date: 04/17/17

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                //input from user, convert to array of words
                Console.WriteLine("Please enter a word, or sentence:");
                string[] sentence = Console.ReadLine().ToLower().Trim().Split(' ');

                //translation of string array
                string translation = PLTranslator(sentence);

                //output
                Console.WriteLine(translation.Trim());

            //prompt user to continue
            } while (Continue());

        }

        //loops through string array and translates each word
        public static string PLTranslator(string[] input)
        {
            string PigLatin = "";
            char[] vowels = new char[5] { 'a', 'e', 'i', 'o', 'u' };

            foreach (string item in input)
            {

                if (CheckFirstLetter(item))
                {
                    string result = item + "way";
                    PigLatin = PigLatin + " " + result;
                }
                else if (item.IndexOfAny(vowels) == -1)
                {
                    PigLatin = PigLatin + " " + item;
                }
                else
                {
                    string result2 = item.Substring(1) + item.Remove(1);

                    while (!CheckFirstLetter(result2))
                    {
                        result2 = result2.Substring(1) + result2.Remove(1);
                    }

                    PigLatin = PigLatin + " " + result2 + "ay";
                }

            }

            return PigLatin;
        }

        //checks first letter for vowel/consonant
        public static bool CheckFirstLetter(string input)
        {
            char[] word = input.ToCharArray();

            if (word[0] == 'a' || word[0] == 'e' || word[0] == 'i' || word[0] == 'o' || word[0] == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("Do you want to continue? (y/n)");

            string input = Console.ReadLine();

            if (input.ToLower() == "n")
            {
                return false;
            }
            else if (input.ToLower() == "y")
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid input");
                Continue();
                return true;
            }

        }
    }
}

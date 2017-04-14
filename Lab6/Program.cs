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
                string[] sentence = ToStringArray(Console.ReadLine().ToLower());

                string translation = PLTranslator(sentence);

                Console.WriteLine(translation.Trim());

            } while (Continue());

        }

        public static string[] ToStringArray(string input)
        {
            string[] words = input.Split(' ');
            return words;
        }

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

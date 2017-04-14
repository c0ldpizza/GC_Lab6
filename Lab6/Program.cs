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

                string[] sentence = ToStringArray(Console.ReadLine());

                char[] words = ;
                

            } while (Continue());

        }

        public static string[] ToStringArray(string input)
        {
            string[] words = input.Split(' ');
            return words;
        }

        public static char[] ToCharArray(string[] input)
        {
            foreach (var item in input)
            {

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

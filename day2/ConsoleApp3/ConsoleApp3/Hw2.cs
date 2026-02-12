using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Hw2
    {
        static void Main()
        {
            Console.WriteLine("Enter the sentance:");
            string sentance = Console.ReadLine();

            string[] words = sentance.Split(' ');
            int count = 0;

            foreach (string word in words)
            {
                string lowerWord = word.ToLower();
                char[] arr = lowerWord.ToCharArray();
                Array.Reverse(arr);
                string reversed = new string(arr);

                if (lowerWord.Equals(reversed) && lowerWord.Length > 1)
                {
                    count++;
                }


            }
            Console.WriteLine("Tatal Count of Palindrome words: " + count);

        }
    }
}

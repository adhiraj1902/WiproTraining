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
            string sentance = "Welcome All liril is soap Malayalam is language madam is heading company";
            Console.WriteLine(sentance);

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
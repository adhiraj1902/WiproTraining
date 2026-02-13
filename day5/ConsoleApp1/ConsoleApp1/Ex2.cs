using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string to check: ");
            string sentence = Console.ReadLine();

            // Convert to lowercase
            sentence = sentence.ToLower();

            // Remove non-alphanumeric characters
            StringBuilder sb = new StringBuilder();

            foreach (char ch in sentence)
            {
                if (char.IsLetterOrDigit(ch))
                {
                    sb.Append(ch);
                }
            }

            string cleaned = sb.ToString();

            // Reverse entire string
            char[] arr = cleaned.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            // Compare
            if (cleaned == reversed)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}


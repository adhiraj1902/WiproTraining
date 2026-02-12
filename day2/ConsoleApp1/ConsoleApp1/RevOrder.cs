using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RevOrder
    {
        static void Main()
        {
            
            string sentance = Console.ReadLine();
            string[] words = sentance.Split(' ');

            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 1)
                {
                    char[] arr = words[i].ToCharArray();
                    Array.Reverse(arr);
                    words[i] = new string(arr);
                }
            }
            Console.WriteLine(string.Join(" ", words));

        }
    }
}

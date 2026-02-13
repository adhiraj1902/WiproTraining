using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter K value:");
            int K = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter String");
            string str = Console.ReadLine();
           
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < sb.Length; i++)
            {
                int frequency = 0;
                for (int j = 0; j < str.Length; j++) 
                {
                    if (sb[i] == sb[j])
                    {
                        frequency++;

                    }
                }
                if (frequency == K)
                {
                    sb.Append(sb[i]);

                }
            }

            if (sb.Length > 0)
            {
                Console.WriteLine("first non repeating char is: " + sb[0]);
            }
            else
            {
                Console.WriteLine(" Not found ");
            }
        }
    }
}


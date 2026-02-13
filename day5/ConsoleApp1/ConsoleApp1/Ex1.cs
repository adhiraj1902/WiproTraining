using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ex1
    {
        static void Main(string[] args)
        {
            string str = "geeksforgeeks";
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                int frequency = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        frequency++;

                    }
                }
                if (frequency == 1)
                {
                    sb.Append(str[i]);

                }
            }

            if (sb.Length > 0)
            {
                Console.WriteLine("first non repeating char is: " + sb[0]);
            }
            else
            {
                Console.WriteLine(" $ ");
            }
        }
    }
}
    


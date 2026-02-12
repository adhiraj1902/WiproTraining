using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Hw1
    {
        public void Show()
        {
            string name = "Welcome to C# programming from Wipro Training ";
            Console.WriteLine(name);

            string[] words = name.Split(' ');
            Console.WriteLine("After alternate word reverse string will be :");
            for (int i = 0; i < words.Length; i++)
            {
                if (i % 2 == 1)
                {
                    char[] ch = words[i].ToCharArray();
                    Array.Reverse(ch);
                    words[i] = new string(ch);
                }

            }
            Console.WriteLine(string.Join(" ", words));
        }
        static void Main()
        {
            Hw1 hw1 = new Hw1();
            hw1.Show();

        }

    }
}

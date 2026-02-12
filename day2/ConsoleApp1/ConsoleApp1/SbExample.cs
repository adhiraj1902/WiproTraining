using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class SbExample
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder("Welcome to C# Programming...");
            Console.WriteLine(sb);
            sb.Insert(7, "Adhiraj ");
            Console.WriteLine(sb);
            sb.Remove(5, 6);
            Console.WriteLine(sb);
            sb.Append("Rahul");
            Console.WriteLine(sb);
        }
    }
}


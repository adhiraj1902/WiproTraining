using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StrEx
    {
        static void Main()
        {
            string str = "Welcome to C# Programming...";
            Console.WriteLine(str);
            Console.WriteLine("Length of String  " + str.Length);
            Console.WriteLine("First Occurrence of char 'e' " + str.IndexOf("e"));
            string s1 = "Aman", s2 = "Neerav", s3 = "Aman";
            Console.WriteLine(s1.Equals(s2));
            Console.WriteLine(s1.Equals(s3));
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s2.CompareTo(s3));
            Console.WriteLine(s1.CompareTo(s3));
            Console.WriteLine("Substring  " + str.Substring(5, 10));
            Console.WriteLine("Replaced String " + str.Replace("C#", "ASP.NET"));
            string students = "Kishore Vijay Aman Irfan Adhiraj Rithwik Akarsh Pranav";
            string[] names = students.Split(' ');
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            string str1 = "Hello";
            string str2 = " World...!";
            string res = string.Concat(str1, str2);
            Console.WriteLine(res);
        }
    }
}


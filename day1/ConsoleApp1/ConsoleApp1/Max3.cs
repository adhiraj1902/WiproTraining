using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Max3
    {
        public void Check(int x, int y, int z)
        {
            int m = x;
            if (m < y)
            {
                m = y;
            }
            if (m < z)
            {
                m = z;
            }
            Console.WriteLine("Max Value  " + m);
        }
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter 3 Numbers    ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            Max3 max3 = new Max3();
            max3.Check(a, b, c);
        }
    }
}

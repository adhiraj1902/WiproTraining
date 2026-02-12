using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CircleProg
    {
        #region CalcMethod
        public void Calc(double radius)
        {
            double area, circ;
            area = Math.PI * Math.Pow(radius, 2) ;
            circ = Math.PI * 2 * radius;
            Console.WriteLine("Area of Circle  " + area);
            Console.WriteLine("Circumferance   " + circ);
        }
        #endregion Calcmethod
        #region MainMethod
        static void Main()
        {
            double radius;
            Console.WriteLine("Enter Radius  ");
            radius = Convert.ToDouble(Console.ReadLine());
            CircleProg circleProg = new CircleProg();
            circleProg.Calc(radius);

        }
#endregion MainMethod 

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Welcome to Line Comparison Program---------\n");
            Comparison line1 = new Comparison(1, 2, 3, 4);
            Comparison line2 = new Comparison(5, 6, 3, 4);
            if (line1.CalculateLineEqual() == line2.CalculateLineEqual())
            {
                Console.WriteLine("Both Lines Are Equal\n");
            }
            else
            {
                Console.WriteLine("Lines Are Not Equal\n");
            }
            Console.ReadLine();

        }
    }
}

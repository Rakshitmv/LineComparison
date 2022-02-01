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
            Comparison comparison = new Comparison(2,4,6,9);
            comparison.CalculateLength();
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("a is greater than b.");
            }
            else if (b > a)
            {
                Console.WriteLine("b is greater than a.");
            }
            else
            {
                Console.WriteLine("Numbers are equal.");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter amount of money you want to put: ");
            double m = double.Parse(Console.ReadLine());
            double percent = m * 0.2;
            Console.Write("Enter number of years: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                m += percent;
            }
            Console.Write("In {0} years ballance of your account will be {1}", n, m);

            Console.ReadLine();
        }
    }
}

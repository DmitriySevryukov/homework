using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_10._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.Write("Sum from 1 to {0} is {1}", num, Sum(num));
            } else
            {
                Console.Write("Number should be greater than 1");
            }
            

            Console.ReadLine();
        }

        static long Sum(int n)
        {
            long result = 0;
            for (int i = 0; i <= n; i++)
            {
                result += i;
            }
            return result;
        }
    }
}

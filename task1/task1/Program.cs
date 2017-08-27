using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int second = int.Parse(Console.ReadLine());
            int sum = 0;
            int average = 0;
            int counter = 0;

            if (first == second)
            {
                average = first;
            } else
            {
                if (first < second)
                {
                    for (int i = first; i <= second; i++)
                    {
                        sum += i;
                        counter++;
                    }
                }
                else
                {
                    for (int i = second; i <= first; i++)
                    {
                        sum += i;
                        counter++;
                    }
                }
                average = sum / counter;
            }
            if (average % 2 == 0)
            {
                Console.Write("Average is {0}. it's even", average);
            } else
            {
                Console.Write("Average is {0}. It's odd", average);
            }





            Console.ReadLine();
        }
    }
}

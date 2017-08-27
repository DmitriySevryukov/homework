using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert height of pyramid: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                int spaces = height - i;
                if (spaces > 0)
                {
                    for (int k = 1; k <= spaces; k++)
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = 1; j <= i * 2 - 1; j++)
                {
                    
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}

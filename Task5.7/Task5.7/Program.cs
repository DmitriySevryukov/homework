﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter value of number N: ");
            int n = int.Parse(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            Console.Write("N! = " + factorial);

            Console.ReadLine();
        }
    }
}

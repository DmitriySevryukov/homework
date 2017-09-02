using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of matrix: ");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            Random rand = new Random();


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rand.Next(10, 40);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int k = 0; k < size; k++)
            {
                for (int i = 0; i < size - 1; i++)
                {
                    for (int j = 0; j < size - 1; j++)
                    {
                        if (i == j)
                        {
                            if (matrix[i, j] > matrix[i + 1, j + 1])
                            {
                                int temp = matrix[i, j];
                                matrix[i, j] = matrix[i + 1, j + 1];
                                matrix[i + 1, j + 1] = temp;
                            }
                        }
                    }
  
                }
            }
            
            Console.WriteLine();




            Console.WriteLine("Sorted matrix:");
           
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

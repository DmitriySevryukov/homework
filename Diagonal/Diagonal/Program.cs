using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of matrix: ");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            Random rand = new Random();
            int[] tempMatrix = new int[size];
            int tempCounter = 0;


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rand.Next(10, 40);
                    Console.Write(matrix[i, j] + " ");
                    if (i == j)
                    {
                        tempMatrix[tempCounter] = matrix[i, j];
                        tempCounter++;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Diagonal:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(tempMatrix[i] + " ");
            }
            Console.WriteLine("\n");

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - 1; j++)
                {
                    if (tempMatrix[j] > tempMatrix[j + 1])
                    {
                        int temp = tempMatrix[j];
                        tempMatrix[j] = tempMatrix[j + 1];
                        tempMatrix[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("Sorted diagonal:");
            for (int i = 0; i < size; i++)
            {
                Console.Write(tempMatrix[i] + " ");
            }
            Console.WriteLine("\n");

            Console.WriteLine("Sorted matrix:");
            tempCounter = 0;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = tempMatrix[tempCounter];
                        tempCounter++;
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

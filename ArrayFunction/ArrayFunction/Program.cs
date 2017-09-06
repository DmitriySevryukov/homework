using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ArrayFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of array: ");
            int size = int.Parse(Console.ReadLine());
            if (size > 0)
            {
                int[] numArray = new int[size];
                Random rand = new Random();

                for (int i = 0; i < size; i++)
                {
                    numArray[i] = rand.Next(0, 100);
                    Console.Write(numArray[i] + " ");
                }
                Console.WriteLine();

                Console.WriteLine("The biggest number is " + GetMax(numArray));
                Console.WriteLine("The smallest number is " + GetMin(numArray));
            }
            else
            {
                Console.Write("Enter the number greater than 1");
            }
                
            

            Console.ReadLine();
        }
         
        static int GetMax(int[] array)
        {
            int result = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > result)
                {
                    result = array[i];
                }   
            }
            return result;
        }

        static int GetMin(int[] array)
        {
            int result = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < result)
                {
                    result = array[i];
                }
            }
            return result;
        }

    }
}

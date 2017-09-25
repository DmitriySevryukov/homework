using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = new int[10];
            Random rand = new Random();
            bool repeat = false;
            int first = 0;
            int second = 0;
            int firstVal = 0;
            int secondVal = 0;

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = rand.Next(100);
                Console.Write(intArr[i] + " ");
            }

            Console.WriteLine();

            do
            {
                Console.Write("Enter the first index of array: ");
                try
                {
                    first = int.Parse(Console.ReadLine()) - 1;
                    firstVal = intArr[first];
                    repeat = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Use numbers!");
                    repeat = true;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Use numbers from 1 to 10");
                    repeat = true;
                }

            } while (repeat);


            do
            {
                Console.Write("Enter the second index of array: ");
                try
                {
                    second = int.Parse(Console.ReadLine()) - 1;
                    secondVal = intArr[second];
                    repeat = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Use numbers!");
                    repeat = true;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Use numbers from 1 to 10");
                    repeat = true;
                }

            } while (repeat);

            Console.Write("Sum of the two numbers is " + (intArr[first] + intArr[second]));

            Console.ReadLine();
        }
    }
}

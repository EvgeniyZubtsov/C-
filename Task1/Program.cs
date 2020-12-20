using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmountOfPairsInArray
{
    class Program
    {
      
        static int Number(int[] array, int length)
        {
            int count= 0;
            for (int i = 0; i < length - 1; i++)
            {
                if (array[i] % 3 == 0 || array[i + 1] % 3 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            const int array = 20;
            int[] myArray = new int[array];
            Random random = new Random();
            int result;

            Console.WriteLine("Программа подсчёта пар элементов, в которых хотя бы одно число делится на 3.");
            Console.Write("\nВ следующем массиве [ ");
            for (int i = 0; i < array; i++)
            {
                myArray[i] = random.Next(-10000, 10001);
                Console.Write(myArray[i] + ", ");
            }
            Console.WriteLine("\b\b ]\n");

            result = Number(myArray, array);

            Console.WriteLine($"Количество пар: {result}");

            Console.ReadKey();
        }
    }
}
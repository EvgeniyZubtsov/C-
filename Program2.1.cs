using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEvgeniyZubtsov2._1
{
    class Program
    {

        static int number()
        {
            int a, b, c;
            Console.Write("Введите первое число: ");
            int.TryParse(Console.ReadLine(), out a);
            Console.Write("Введите второе число: ");
            int.TryParse(Console.ReadLine(), out b);
            Console.Write("Введите третье число: ");
            int.TryParse(Console.ReadLine(), out c);
            if (a < b && a < c)
            {
                return a;
            }
            else if (b < a && b < c)
            {
                return b;
            }
            else return c;


        }
        static void Main(string[] args)
        {
            int min;
            min = number();
            Console.WriteLine("минимальное число: {0}", min);
            Console.ReadLine();
        }
    }
}

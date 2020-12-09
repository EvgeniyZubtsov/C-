using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main()
        {
            int a;
            int count = 0;
            Console.Write("Введите число для подсчета цифр числа ");
            int.TryParse(Console.ReadLine(), out a);
            while (a > 0)
            {

                a /= 10;
                count++;
            }
            Console.WriteLine("Число цифр вводимого числа: {0}", count);
            Console.ReadLine();
        }
    }
}
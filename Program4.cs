using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEvgeniyZubtsov4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int change;
            Console.WriteLine("Написать программу обмена значениями двух переменных:\n а) с использованием третьей переменной;\n б) *без использования третьей переменной.");
            Console.WriteLine("Введите число a: ");
            string first = Console.ReadLine();
            int.TryParse(first, out a);
            Console.WriteLine("Введите число b: ");
            string second = Console.ReadLine();
            int.TryParse(second, out b);
            
            change = a;
            a = b;
            change = b;

            //без 3-ей переменной;
            a = a + b;
            b = a - b;
            a = a - b;



            Console.WriteLine($"a={a}  b={b}");
            Console.ReadLine();
        }
    }
}

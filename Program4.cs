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
            int c;
            Console.WriteLine("Написать программу обмена значениями двух переменных:\n а) с использованием третьей переменной;\n б) *без использования третьей переменной.");
            Console.WriteLine("Введите число a: ");
            string first = Console.ReadLine();
            int.TryParse(first, out a);
            Console.WriteLine("Введите число b: ");
            string second = Console.ReadLine();
            int.TryParse(second, out b);
            Console.WriteLine("Введите число c: ");
            string third = Console.ReadLine();
            int.TryParse(third, out c);
            a = b + c;
            b = c + a;
            c = a + b;
            a = b;
            b = a;
            Console.WriteLine($"a={a}  b={b}  c={c}");
            Console.ReadLine();
        }
    }
}

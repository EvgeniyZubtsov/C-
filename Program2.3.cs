using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HomeworkEvgeniyZubtsov2._3
{
    class Program
    {
        static int Get() 
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод");
                else return x;
        }
        static string attempt(int x)
        {
            string s = "";
            if (x % 10 == 1 && x != 11) s += " попытка";
            else
            // 
            if ((x >= 2 && x <= 4) || (x >= 22 && x <= 24) || (x >= 32 && x <= 34) || (x > 41 && x < 45)) s += " попытки";
            else
                // 
                if ((x == 0) || (x == 11) || (x >= 5 && x <= 20) || (x >= 25 && x <= 30) || (x >= 35 && x < 41) || (x > 44 && x < 51)) s += " попыток";
            return s;
        }
        static void Main(string[] args)
        {
            int count = 4;
            int input = 0;
            int number = 0;
            while (true)
            {
                Console.Write("Введите любое число: ");
                int num = Get();
                {
                    if (count <= 0 || num == 0)
                    {
                        Console.WriteLine("Вы ввели 0 или число попыток не осталось");
                        input++;
                        Console.ReadLine();
                        break;
                    }
                    else if (num < 0)
                    {
                        Console.WriteLine("Вы ввели число меньше 0");
                        count--;
                        Console.WriteLine("У вас осталось {0}", + count + attempt(count) );
                        input++;
                    }
                    else if (num % 2 == 0)
                    {
                        count--;
                        Console.WriteLine("У вас осталось {0}", + count + attempt(count));
                        input++;
                    }
                    else if (num % 2 == 1)
                    {
                        count--;
                        number += num;
                        Console.WriteLine("У вас осталось {0}", + count + attempt(count));
                        input++;
                    }
                }
            }
            Console.WriteLine("Получилось число:{0}, а число вводов {1}", number, input);
            Console.ReadLine();
        }
    }
}
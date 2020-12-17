using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEvgeniyZubtsovlesson3._2
{
    class Program
    {
        static int Check()
        {
            int result = 0;
            bool exceptionCatched;
            do
            {
                exceptionCatched = false;
                try
                {
                    result = int.Parse(Console.ReadLine());
                    if (result < 0)
                    {
                        throw new Exception("Введенное число " + result + " меньше 0");
                    }
                }
                catch (Exception error)
                {
                    exceptionCatched = true;
                    string message = error.Message;
                    Console.WriteLine(message);
                    Console.Write("Пожалуйста, повторите ввод: ");
                }

            } while (exceptionCatched);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа подсчета нечетных положительных чисел");
            Console.WriteLine("Введите числа по одному: ");
            int summa = 0;
            int Numbers = 0;
            while (true)
            {
                int number = Check();
                if (number == 0)
                {
                    break;
                }
                else if (number > 0 && number % 2 == 1)
                {
                    Numbers++;
                    summa += number;
                }
            }

            Console.WriteLine("Количество чисел: " + Numbers + " cумма чисел равна " + summa );

            Console.ReadLine();
        }
    }
}

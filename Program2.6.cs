using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEvgeniyZubtsovlesson2._6
{
    class Program
    {
        
        static int Int() 
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Неверный ввод: ");
                else return x;
        }

        static bool GoodNum( int value)
        {
            string s = Convert.ToString(value);
            int summa = 0;
            for (int i = 0; i < s.Length; i++)
            {
                summa += s[i] - '0';
            } if (value % summa == 0)
                return true;
            else
                return false;

        }
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Программа подсчета количества «хороших» чисел в диапазоне");
            Console.Write("Введите диапозон чисел от 1 до ");
            int num = Int();
            DateTime start = DateTime.Now;

            for (int i = 1; i <= num; i++)
            {
                if (GoodNum(i))
                {
                    count++;
                }
            }
            Console.Write("Время работы программы: ");
            Console.WriteLine(DateTime.Now - start);
            Console.WriteLine("Хороших чисел в нашем диапазоне " + count);
            Console.ReadLine();

        }
    }
}

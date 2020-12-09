using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEvgeniyZubtsov6
{
    class Program
    {
        static void Print()
        {
            Console.WriteLine("Создание методов по домашнему заданию");

        }

        static int Pause (int x)
        {
            int number;
            while (true)
            {

                Console.WriteLine("Введите число ");
                bool f = int.TryParse(Console.ReadLine(), out number);
                if (!f)
                {
                    Console.WriteLine("Вы ввели не число");
                    continue;
                } else if (number < 0)
                {
                    Console.WriteLine("Вы ввели число меньше 0");
                }
                else
                { 
                number +=x;
                return number;
                }
                
            }
            
        }
        static void Main(string[] args)
        {         
            Print();
            int x;
            Console.WriteLine("Введите число z ");
            string num = Console.ReadLine();
            int.TryParse(num, out x);
            int all = Pause(x);
            Console.WriteLine("возвращаемое число от метода Pause " + all);
            Console.ReadLine();


        }
    }
}

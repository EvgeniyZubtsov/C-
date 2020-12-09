using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEvgeniyZubtsovlesson2._4
{
    class Program
    {
        static int Get()
        {
            Console.WriteLine("Введите любое положительное число: ");
            while (true)
            if (!int.TryParse(Console.ReadLine(), out int x))
                Console.Write("Нужно ввести именно число");
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
                if ((x == 0)||(x == 11) || (x >= 5 && x <= 20) || (x >= 25 && x <= 30) || (x >= 35 && x < 41) || (x > 44 && x < 51)) s += " попыток";
            return s;
        }
        static bool check(string login, string password)
        {
            if (login =="root" && password == "Geekbrains")         
                return true;
            else
                return false;          
        }



        static void Main(string[] args)
        {
            int count = 3;
            do
            {
                Console.WriteLine("Вам необходимо ввести корректные логин и пароль");
                Console.Write("Введите ваш логин ");
                string login = Console.ReadLine();
                Console.Write("Введите ваш пароль ");
                string password = Console.ReadLine();

                if (check(login, password))
                {
                    Console.WriteLine("Авторизация успешна");
                    break;
                }
                else
                {
                    count--;
                    Console.WriteLine("Неверный пароль. У вас осталось " + count + attempt(count));
                }



            } while (count > 0);
            Console.ReadLine();
        }
    }
}

using System;
using System.Text.RegularExpressions;

namespace CorrectLogin
{
    class Program
    {
        
        static string Count(int x)
        {
            string s = "";
            // Попытка, когда заканчивается на один, кроме 11.
            if (x % 10 == 1 && x != 11) s += " попытка";
            else
                // Попытки
                if ((x >= 2 && x <= 4) || (x >= 22 && x <= 24) || (x >= 32 && x <= 34) || (x > 41 && x < 45)) s += " попытки";
            else
                    // Попыток
                    if ((x == 11) || (x >= 5 && x <= 20) || (x >= 25 && x <= 30) || (x >= 35 && x < 41) || (x > 44 && x < 51)) s += " попыток";
            return s;
        }


        static bool Check(string login)
        {
            int length = login.Length;
            if (length >= 2 && length <= 10)
            {
                bool check = true;
                char letter = login[0];
                if (Char.IsDigit(letter))
                    return false;
                for (int i = 1; i < length; i++)
                {
                    letter = login[i];
                    if (!(Char.IsDigit(letter) || Letter(letter)))
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                    return true;
            }
            return false;
        }

        /// <summary>Метод проверки на соответствие логина требованиям через регулярные выражения</summary>
        /// <param name="login">Значение логина</param>
        /// <returns></returns>
        static bool CheckReg(string login)
        {
            char letter = login[0];
            if (Char.IsDigit(letter))
                return false;
            if (!Regex.IsMatch(login, @"^[a-zA-Z0-9]+${2,10}"))
                return false;
            return true;
        }

        /// <summary>Метод проверяет, что символ - латинская буква</summary>
        /// <param name="letter">Символ</param>
        /// <returns></returns>
        private static bool Letter(char letter)
        {
            int num = letter;
            if ((num >= 65 && num <= 90) || (num >= 97 && num <= 122))
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Программа проверки корректности логина.");
            int step = 3;

            do
            {
                Console.Write("Введите логин: ");
                string login = Console.ReadLine();

                if (Check(login) && CheckReg(login))
                {
                    Console.WriteLine();
                    break;
                }
                else
                {
                    step--;
                    Console.WriteLine("Неверный ввод логина. \nДолжны быть соблюдены следующие условия:"
                        + "\nдлина строки 2 до 10 символов;"
                        + "\nбуквы только латинского алфавита или цифры;"
                        + "\nцифра не может быть первой."
                        + "У Вас осталось " + step + Count(step));
                }

            } while (step > 0);

            Console.WriteLine("Логин корректен!");

            Console.ReadLine();
        }
    }
}
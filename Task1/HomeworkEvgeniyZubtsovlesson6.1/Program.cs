using System;

namespace HomeworkEvgeniyZubtsovlesson6
{

    public delegate double Fun(double a, double x);

    class Program
    {

        public static void Table(Fun F, double a, double x, double b)
        {
            Console.WriteLine("----- A ------- X -------- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} | {2,8:0.000} |", a, x, F(a, x));
                x += 1;
            }
            Console.WriteLine("-----------------------------------");
        }

        public static double MyFunc(double a, double x)
        {
            return a * x * x;
        }

        public static double MySin(double a, double x)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {
      
            Console.WriteLine("Таблица функции a*x^2:");
            Table(new Fun(MyFunc), -1, -2, 2);
            Console.WriteLine("Таблица функции a*sin(x):");
            Table(new Fun(MyFunc), 2, -2, 2);

            Console.ReadLine();
        }
    }

}
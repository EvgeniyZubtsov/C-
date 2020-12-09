using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEvgeniyZubtsov3
{
    class Program
    {

        static int Say()
        {
            int r;
            Console.WriteLine("Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле\n r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2).\n Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой)");
            Console.WriteLine("Введите x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            r = (int)Math.Sqrt((Math.Pow(x2, 2) - Math.Pow(x1, 2)) + (Math.Pow(y2, 2) - Math.Pow(y1, 2)));
            Console.WriteLine("Результат: " + r);
            return r;
        }

        static void Main(string[] args)
        {

            Say();                    
            Console.ReadLine();
        }
    }
}

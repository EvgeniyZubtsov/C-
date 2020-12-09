using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkEvgeniyZubtsovlesson2._5
{
    class Program
    {
        static string checknorm(double imt , double height)
        {
            string result = "";
            if (imt >= 18.5 && imt <= 24.99)
                Console.WriteLine("У вас все в норме");
            else if (imt < 18.5)
            {
                double recom = (18.5 - imt)* height * height;
                result = string.Format("Вам необходимо набрать{0:00}кг",recom);
            }
            else if (imt > 24.99)
            {
                double recom = (imt - 24.99) * height * height;
                result = string.Format("Вам необходимо сбросить {0:0.00}кг" ,recom );
            }
            return result ;
        }     

        static void Main(string[] args)
        {
            Console.WriteLine("Необходимо ввести рост и массу для подсчета индекса масса и рекомендаций по ней");
            Console.Write("Введите вашу массу ");
            double massa = double.Parse(Console.ReadLine());
            Console.Write("Введите ваш рост ");
            double height = double.Parse(Console.ReadLine());
            height /= 100;
            Console.Write("Индекс вашего тело состовляет: ");
            double imt = massa / (height * height);
            Console.WriteLine("{0:0.00}", imt);
            Console.WriteLine(checknorm(imt, height));
            Console.ReadLine();
        }
    }
}

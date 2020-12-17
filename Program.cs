using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
    {

        // Структура для представления комплексного числа
        struct Complex
        {
            public double im;
            public double re;

            //  Метод сложения с другим комплексным числом 
            public Complex Plus(Complex x)
            {
                Complex y;
                y.im = im + x.im;
                y.re = re + x.re;
                return y;
            }

            //  Метод разности с другим комплексным числом 
            public Complex Minus(Complex x)
            {
                Complex y;
                y.im = im - x.im;
                y.re = re - x.re;
                return y;
            }

            //  Метод произведения с другим комплексным числом 
            public Complex Multi(Complex x)
            {
                Complex y;
                y.im = re * x.im + im * x.re;
                y.re = re * x.re - im * x.im;
                return y;
            }

            //  Метод представления комплексного числа в удобной форме
            public string ToString()
            {
                return re + "+" + im + "i";
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Complex complex1;
                complex1.re = 1;
                complex1.im = 1;

                Complex complex2;
                complex2.re = 2;
                complex2.im = 2;

                Console.WriteLine("Результат структуры:");
                Complex result = complex1.Plus(complex2);
                Console.WriteLine("Результом сложения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
                    + result.ToString());
                result = complex1.Multi(complex2);
                Console.WriteLine("Результом умножения чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
                   + result.ToString());
                result = complex1.Minus(complex2);
                Console.WriteLine("Результом вычитания чисел: " + complex1.ToString() + " и " + complex2.ToString() + " является "
                   + result.ToString());

                Console.WriteLine();

                Console.WriteLine("Результат работы класса:");
                CComplex ccomplex1 = new CComplex(1, 1);
                CComplex ccomplex2 = new CComplex(2, 2);
                CComplex zresult = ccomplex1.Plus(ccomplex2);
                Console.WriteLine("Результом сложения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
                    + zresult.ToString());
                zresult = ccomplex1.Multi(ccomplex2);
                Console.WriteLine("Результом умножения чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
                   + zresult.ToString());
                zresult = ccomplex1.Minus(ccomplex2);
                Console.WriteLine("Результом вычитания чисел: " + ccomplex1.ToString() + " и " + ccomplex2.ToString() + " является "
                   + zresult.ToString());

                Console.ReadKey();
            }
        }
}

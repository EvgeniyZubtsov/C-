using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{

    class CComplex
    {
        double im;
        double re;

        //Конструктор без параметров
        public CComplex()
        {
            im = 0;
            re = 0;
        }

        // Конструктор с параметрами
        public CComplex(double _im, double re)
        {
            im = _im;
            this.re = re;
        }

        //  Метод сложения с другим комплексным числом>
        public CComplex Plus(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        // Метод разности с другим комплексным числом 
        public CComplex Minus(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        //  Метод произведения с другим комплексным числом 
        public CComplex Multi(CComplex x2)
        {
            CComplex x3 = new CComplex();
            x3.im = re * x2.im + im * x2.re;
            x3.re = re * x2.re - im * x2.im;
            return x3;
        }

        //  Метод представления комплексного числа в удобной форме
        public string ToString()
        {
            return re + "+" + im + "i";
        }

    }
}
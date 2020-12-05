using System;

class IMT
{
  
    static void Main(string[] args)
    {
        
        double h, m;
        double result;
        Console.Write("Введите ваш рост в метрах: ");
        string Height = Console.ReadLine();
        double.TryParse(Height, out h);
        Height = string.Format("{0:f2}", h);
        Console.Write("Введите ваш вес:");
        string Weight = Console.ReadLine();
        double.TryParse(Weight, out m);
        Weight = String.Format("{0:f2}", m);
        Console.WriteLine("Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.");
        result = Math.Round (m / (h * h));
        Console.WriteLine("Ваше значение ИМТ: " + result);
        Console.ReadLine();
    }
}

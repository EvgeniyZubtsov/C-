using System;

class Anketa
{

    static void Main(string[] args)
    {
        Console.WriteLine("Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес)." +
            "В результате вся информация выводится в одну строку" +
            "а) используя склеивание;" +
            "б) используя форматированный вывод;" +
            "в) используя вывод со знаком $");
        double h, m;
        Console.Write("Введите ваше имя: ");
        string Firstname = Console.ReadLine();
        Console.Write("Введите вашу фамилию: ");
        string Lastname = Console.ReadLine();
        Console.Write("Введите ваш возвраст: ");
        string Age = Console.ReadLine();
        Console.Write("Введите ваш рост в метрах: ");
        string Height = Console.ReadLine();
        h = Convert.ToDouble(Height);
        Height = string.Format("{0:f2}", h);
        Console.Write("Введите ваш вес:");
        string Weight = Console.ReadLine();
        m = Convert.ToDouble(Weight);
        Weight = String.Format("{0:f2}", m);
        Console.WriteLine($"Имя: {Firstname} Фамилия: {Lastname} Возраст: {Age} Рост: {Height}м Вес: {Weight}");
        Console.ReadLine();
    }
}

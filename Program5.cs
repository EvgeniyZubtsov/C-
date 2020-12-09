using System;

public class Program
{
    public static void Main()
    {
      

        string name = "Evgeniy Zubtsov";
        string city = "Moscow";
        string all = name + " "+ city;

        Print(name, city, all);
    }

    static void Print(string name, string city, string all)
    {
        int x = 50;
        int y = 15;
        Console.WriteLine(all);
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(all);
        Console.ReadLine();
    }
}
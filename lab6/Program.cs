using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("v3");
        // Создание объектов котов и тигров
        Cat Barsic = new Cat("Барсик");
        Cat Felix = new Cat("Феликс");
        Cat Simba = new Cat("Симба");
        Tiger Leo = new Tiger("Лео");
        Tiger Hercules = new Tiger("Геркулес");

        Console.WriteLine("Задание 1.1");
        // Вызов метода мяу для кота
        Barsic.Meow();
        Console.WriteLine("Сколько раз мяукнуть?");
        string n = Console.ReadLine();
        if (int.TryParse(n, out int n1)) {
            if (n1 >= 0) Felix.MeowN(n1);  // Мяукать N раза
            else Console.WriteLine("Он не может отрицательно мяуать? Вы что глупый хозяин?");
        }
        Console.WriteLine("\nЗадание 1.2");
        // Список котов
        var cats = new List<Cat> { Felix, Simba };
        MeowDetect.Meowable(cats);  // Мяукаем всех котов

        // Список тигров
        var tigers = new List<Tiger> { Leo, Hercules };
        MeowDetect.Meowable(tigers);  // Мяукаем всех тигров

        Console.WriteLine("\nЗадание 1.3");
        // Счётчик мяуканий для Феликса
        var CountFelix = new Count(Felix);
        MeowDetect.Meowable(new List<IMeowable> { CountFelix });

        // Считаем количество мяуканий
        CountFelix.Meow();
        CountFelix.Meow();
        CountFelix.Meow();
        Console.WriteLine($"Феликс мяукал {CountFelix.Meow_Count} раз(а)");

        Console.WriteLine("\nЗадание 2");
        // Пример работы с дробями
        Fraction fraction1 = new Fraction(1, 4);
        Fraction fraction2 = new Fraction(2, 7);
        Fraction fraction3 = new Fraction(-3, 8);
        Fraction fraction4 = fraction1 + fraction3;  // Складываем две дроби

        Console.WriteLine(fraction4);  // Выводим результат сложения
        Console.WriteLine(fraction1);  // Выводим первую дробь
        Console.WriteLine("1/4 + 2/7 = " + $"{fraction1 + fraction2}");
        Console.WriteLine("2/7 - -3/8 = " + $"{fraction2 - fraction3}");
        Console.WriteLine("2/7 + -3/8 = " + $"{fraction2 + fraction3}");
        Console.WriteLine("-3/8 / 2/7 = " + $"{fraction3 / fraction2}");
        Console.WriteLine("-3/8 * 2/7 = " + $"{fraction3 * fraction2}");
    }
}









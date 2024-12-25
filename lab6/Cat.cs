using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Класс кота

public class Cat : IMeowable
{
    private string Name;

    public string name
    {
        get { return Name; }
        set { Name = value; }
    }

    public Cat(string name)
    {
        this.name = name;
    }

    // Метод для вывода имени кота
    public override string ToString()
    {
        return $"Имя: {name}";
    }

    // Метод, чтобы кот мяукал один раз
    public void Meow()
    {
        Console.WriteLine($"{name}: мЯу!");
    }

    // Метод, чтобы кот мяукал несколько раз
    public void MeowN(int N)
    {
        if (N <= 0)
        {
            Console.WriteLine($"{name} походу умер.");
            return;
        }

        string meowing = string.Join("-", Enumerable.Repeat("мЯу", N));
        Console.WriteLine($"{name}: {meowing}!");
    }
}
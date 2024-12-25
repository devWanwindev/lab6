using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Класс тигра
public class Tiger : IMeowable
{
    private string Name;

    public string name
    {
        get { return Name; }
        set { Name = value; }
    }

    public Tiger(string name)
    {
        this.name = name;
    }

    // Метод для вывода "МРЯУ" тигра
    public void Meow()
    {
        Console.WriteLine($"{name}: МРЯУ!");
    }
}
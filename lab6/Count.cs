using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Класс для подсчёта количества мяуканий
public class Count : IMeowable
{
    private readonly IMeowable _meowable;
    public int Meow_Count { get; private set; }

    public Count(IMeowable meowable)
    {
        _meowable = meowable;
    }

    // Метод, который увеличивает счётчик и вызывает мяу
    public void Meow()
    {
        Meow_Count++;
        _meowable.Meow();
    }
}
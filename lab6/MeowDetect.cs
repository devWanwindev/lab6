using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static class MeowDetect
{
    public static void Meowable(IEnumerable<IMeowable> meowables)
    {
        foreach (var meowable in meowables)
        {
            meowable.Meow();
        }
    }
}
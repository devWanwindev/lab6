using System;

public class Fraction : IClonable, IOperationable
{
    private int numerator;
    private int denominator;

    public int Numerator
    {
        get { return numerator; }
        set { numerator = value; Simplify(); }
    }

    public int Denominator
    {
        get { return denominator; }
        set
        {
            if (value == 0)
            {
                throw new ArgumentException("Делитель не может быть 0");
            }
            if (value < 0)
            {
                numerator = -numerator;
                denominator = -value;
            }
            else
            {
                denominator = value;
            }
            Simplify();
        }
    }

    public Fraction(int num, int denom)
    {
        if (denom == 0)
        {
            throw new ArgumentException("Делитель не может быть 0");
        }
        numerator = num;
        denominator = denom;
        Simplify();
    }

    public override string ToString()
    {
        return numerator + "/" + denominator;
    }

    private void Simplify()
    {
        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int newNum = a.numerator * b.denominator + b.numerator * a.denominator;
        int newDenom = a.denominator * b.denominator;
        return new Fraction(newNum, newDenom);
    }

    public static Fraction operator -(Fraction a, Fraction b)
    {
        int newNum = a.numerator * b.denominator - b.numerator * a.denominator;
        int newDenom = a.denominator * b.denominator;
        return new Fraction(newNum, newDenom);
    }

    public static Fraction operator *(Fraction a, Fraction b)
    {
        return new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);
    }

    public static Fraction operator /(Fraction a, Fraction b)
    {
        if (b.numerator == 0)
        {
            throw new ArgumentException("Делитель не может быть 0");
        }
        return new Fraction(a.numerator * b.denominator, a.denominator * b.numerator);
    }

    public override bool Equals(object obj)
    {
        if (obj is Fraction other)
        {
            return numerator == other.numerator && denominator == other.denominator;
        }
        return false;
    }

    public Fraction Clone()
    {
        return new Fraction(numerator, denominator);
    }

    public double GetValue()
    {
        return (double)numerator / denominator;
    }

    public void SetNumerator(int num)
    {
        numerator = num;
        Simplify();
    }

    public void SetDenominator(int denom)
    {
        if (denom == 0)
        {
            throw new ArgumentException("Делитель не может быть 0");
        }
        denominator = denom;
        Simplify();
    }
}
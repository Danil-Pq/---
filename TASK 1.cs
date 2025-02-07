using System;

class Fraction
{
    private int _numerator;
    private int _denominator;

    public int Numerator
    {
        get { return _numerator; }
        set { _numerator = value; }
    }

    public int Denominator
    {
        get { return _denominator; }
        set
        {
            if (value == 0)
                throw new NotCorrectlyDenominatorException("Знаменатель не может быть равен 0");
            _denominator = value;
        }
    }

    public double DecimalValue
    {
        get { return (double)_numerator / _denominator; }
    }

    public Fraction(int numerator, int denominator)
    {
        Numerator = numerator;
        Denominator = denominator;
        Simplify();
    }

    public Fraction Add(Fraction other)
    {
        int newNumerator = _numerator * other.Denominator + other.Numerator * _denominator;
        int newDenominator = _denominator * other.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Subtract(Fraction other)
    {
        int newNumerator = _numerator * other.Denominator - other.Numerator * _denominator;
        int newDenominator = _denominator * other.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Multiply(Fraction other)
    {
        int newNumerator = _numerator * other.Numerator;
        int newDenominator = _denominator * other.Denominator;
        return new Fraction(newNumerator, newDenominator);
    }

    public Fraction Divide(Fraction other)
    {
        int newNumerator = _numerator * other.Denominator;
        int newDenominator = _denominator * other.Numerator;
        return new Fraction(newNumerator, newDenominator);
    }

    private void Simplify()
    {
        int gcd = GCD(Math.Abs(_numerator), Math.Abs(_denominator));
        _numerator /= gcd;
        _denominator /= gcd;
        if (_denominator < 0)
        {
            _numerator *= -1;
            _denominator *= -1;
        }
    }

    private int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }
}

class NotCorrectlyDenominatorException : Exception
{
    public NotCorrectlyDenominatorException(string message) : base(message) { }
}

class Program
{
    static void Main()
    {
        try
        {
            Fraction f1 = new Fraction(3, 4);
            Fraction f2 = new Fraction(1, 2);

            Console.WriteLine($"f1 = {f1}");
            Console.WriteLine($"f2 = {f2}");

            Fraction sum = f1.Add(f2);
            Console.WriteLine($"Сумма: {sum}");

            Fraction difference = f1.Subtract(f2);
            Console.WriteLine($"Разность: {difference}");

            Fraction product = f1.Multiply(f2);
            Console.WriteLine($"Произведение: {product}");

            Fraction quotient = f1.Divide(f2);
            Console.WriteLine($"Частное: {quotient}");

            Console.WriteLine($"Десятичное значение f1: {f1.DecimalValue}");
        }
        catch (NotCorrectlyDenominatorException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

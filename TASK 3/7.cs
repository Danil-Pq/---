using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("a\tx\ta*sin(x)");
        for (int a = 1; a <= 10; a++)
        {
            double x = a;
            double result = a * Math.Sin(x);
            Console.WriteLine($"{a}\t{x}\t{result:F4}");
        }
    }
}

Вывод
a	| x	| a*sin(x)
1	| 1	| 0.8415
2	| 2	| 1.8186
3	| 3	| 0.4234
4	| 4	| -3.0272
5	| 5	| -4.7946
6	| 6	| -1.6765
7	| 7	| 4.5989
8	| 8	| 7.9149
9	| 9	| 3.7091
10 | 10 | -5.4402

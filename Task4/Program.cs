using System;

namespace Task4;

public class Program
{
    static bool IsValidTriangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            return false;
        if (a + b <= c || a + c <= b || b + c <= a)
            return false;
        return true;
    }

    static double GetPerimeter(double a, double b, double c)
    {
        return a + b + c;
    }

    static double GetArea(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    static string GetTriangleType(double a, double b, double c)
    {
        if (a == b && b == c)
            return "Рівносторонній";
        if (a == b || b == c || a == c)
            return "Рівнобедрений";

        double max = Math.Max(a, Math.Max(b, c));
        double side1, side2;
        if (max == a)
        {
            side1 = b;
            side2 = c;
        }
        else if (max == b)
        {
            side1 = a;
            side2 = c;
        }
        else
        {
            side1 = a;
            side2 = b;
        }

        double epsilon = 0.0001;
        if (Math.Abs(side1 * side1 + side2 * side2 - max * max) < epsilon)
            return "Прямокутний";

        return "Довільний";
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть сторону a: ");
        string inputA = Console.ReadLine();
        Console.Write("Введіть сторону b: ");
        string inputB = Console.ReadLine();
        Console.Write("Введіть сторону c: ");
        string inputC = Console.ReadLine();

        if (double.TryParse(inputA, out double a) &&
            double.TryParse(inputB, out double b) &&
            double.TryParse(inputC, out double c))
        {
            if (IsValidTriangle(a, b, c))
            {
                double perimeter = GetPerimeter(a, b, c);
                double area = GetArea(a, b, c);
                string type = GetTriangleType(a, b, c);

                Console.WriteLine($"Периметр: {perimeter:F2}");
                Console.WriteLine($"Площа: {area:F2}");
                Console.WriteLine($"Тип трикутника: {type}");
            }
            else
            {
                Console.WriteLine("Трикутник із такими сторонами не існує!");
            }
        }
        else
        {
            Console.WriteLine("Помилка: введіть коректні числа!");
        }
    }
}
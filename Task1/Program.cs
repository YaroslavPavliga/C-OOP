using System;

namespace Task1;

public class Program
{
    static void Main(string[] args)
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Введіть число для перевірки парності: ");
        string input = Console.ReadLine();

        bool success = int.TryParse(input, out int number);

        if (success)
        {
            string message = GetMessage(number);
            Console.WriteLine(message);
        }
        else
        {
            Console.WriteLine("Помилка: Введіть число");
        }
    }
    public static bool IsEven(int number)
    {
        if (number % 2 == 0)
            return true;

        else return false;

    }

    public static string GetMessage(int number)
    {
        bool isEven = IsEven(number);

        if (isEven)
        {
            return "Двері відчинені";
        }

        else
        {
            return "Двері зачинені";
        }   
    }
}   

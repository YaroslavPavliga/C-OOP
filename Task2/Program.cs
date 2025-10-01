using System;

namespace Task2;

public class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int[] numbers = GenerateRandomArray(10, 1, 100);
        Console.WriteLine("Масив чисел:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int sum = GetSum(numbers);
        Console.WriteLine($"Сума: {sum}");

        double average = GetAverage(numbers);
        Console.WriteLine($"Середнє: {average:F2}");

        int min = GetMin(numbers);
        Console.WriteLine($"Мінімум: {min}");

        int max = GetMax(numbers);
        Console.WriteLine($"Максимум: {max}");
    }

    static int[] GenerateRandomArray(int size, int min, int max)
    {
        Random random = new Random();
        int[] array = new int[size];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(min, max + 1);
        }
        return array;
    }

    static int GetSum(int[] numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }

    static double GetAverage(int[] numbers)
    {
        if (numbers.Length == 0) return 0;
        return (double)GetSum(numbers) / numbers.Length;
    }

    static int GetMin(int[] numbers)
    {
        if (numbers.Length == 0) return 0;
        int min = numbers[0];
        foreach (int num in numbers)
        {
            if (num < min)
            {
                min = num;
            }
        }
        return min;
    }

    static int GetMax(int[] numbers)
    {
        if (numbers.Length == 0) return 0;
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }
}
﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть чотири цифри:");

        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int number3 = Convert.ToInt32(Console.ReadLine());
        int number4 = Convert.ToInt32(Console.ReadLine());

        int result = number1 * 1000 + number2 * 100 + number3 * 10 + number4;

        Console.WriteLine($"Результат: {result}");
    }
}


//Console.WriteLine("Hello World");

using System;

class Program
{
    static void Main()
    {
        // Задаем значения M и N
        int M = 1;
        int N = 5;

        // Выводим натуральные числа от M до N
        PrintNumbers(M, N);
    }

    // Рекурсивная функция для вывода натуральных чисел от M до N
    static void PrintNumbers(int M, int N)
    {
        if (M <= N)
        {
            Console.Write($"{M} ");
            PrintNumbers(M + 1, N); // Рекурсивный вызов для следующего числа
        }
    }
}


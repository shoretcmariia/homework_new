//Console.WriteLine("Hello World");
//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.


//M = 4; N = 8 -> "4, 5, 6, 7, 8"


using System;

class Program
{
    static void Main()
    {
        // Задаем значения M и N
        int M = 4;
        int N = 8; 

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



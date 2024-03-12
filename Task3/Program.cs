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
        
        int M = 4;
        int N = 8; 

        
        PrintNumbers(M, N);
    }

  
    static void PrintNumbers(int M, int N)
    {
        if (M <= N)
        {
            Console.Write($"{M} ");
            PrintNumbers(M + 1, N); 
        }
    }
}

M = 1; N = 5 -> "1, 2, 3, 4, 5"


//Console.WriteLine("Hello World");
//Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"

using System;

class Program
{
    static void Main()
    {
       
        int M = 1;
        int N = 5;

        
        PrintNumbers(M, N);
    }

    
    static void PrintNumbers(int M, int N)
    {
        if (M <= N)
        {
            Console.Write($"{M} ");
            PrintNumbers(M + 1, N); 
        }
    }
}



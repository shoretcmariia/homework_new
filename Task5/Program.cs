//Задайте произвольный массив на C#. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.

//[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1

using System;

class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 5, 0, 10, 34 };
        PrintArrayReversed(array, array.Length - 1);
    }

    static void PrintArrayReversed(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write($"{array[index]} ");
            PrintArrayReversed(array, index - 1);
        }
    }
}

using System;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         // Ввод значений M и N
//         Console.Write("Введите значение M: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         // Вывод натуральных чисел в промежутке от M до N с помощью рекурсивной функции
//         PrintNaturalNumbers(m, n);
//     }

//     // Рекурсивная функция для вывода натуральных чисел в промежутке от M до N
//     public static void PrintNaturalNumbers(int m, int n)
//     {
//         // Базовый случай: если m больше n, значит мы достигли конечного значения
//         if (m > n)
//         {
//             return;
//         }

//         // Выводим текущее значение m
//         Console.WriteLine(m);

//         // Рекурсивно вызываем функцию для следующего натурального числа
//         PrintNaturalNumbers(m + 1, n);
//     }
// }



// using System;

// class Program
// {
//     public static void Main(string[] args)
//     {
//         // Ввод значений m и n
//         Console.Write("Введите значение m: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение n: ");
//         int n = int.Parse(Console.ReadLine());

//         // Вычисление значения функции Аккермана
//         int result = AckermannFunction(m, n);

//         // Вывод результата
//         Console.WriteLine($"Результат функции Аккермана для m={m} и n={n} равен {result}");
//     }

//     // Рекурсивная функция для вычисления функции Аккермана
//     public static int AckermannFunction(int m, int n)
//     {
//         // Базовый случай: если m равно 0, возвращаем n + 1
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         // Если m больше 0 и n равно 0, рекурсивно вызываем функцию с аргументами (m-1, 1)
//         else if (m > 0 && n == 0)
//         {
//             return AckermannFunction(m - 1, 1);
//         }
//         // Если m больше 0 и n больше 0, рекурсивно вызываем функцию с аргументами (m-1, A(m, n-1))
//         else
//         {
//             return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//         }
//     }
// }




using System;

class Program
{
    public static void Main(string[] args)
    {
        // Произвольный массив
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

        // Вывод элементов массива, начиная с конца, с использованием рекурсии
        PrintArrayReversed(array, array.Length - 1);
    }

    // Рекурсивная функция для вывода элементов массива, начиная с конца
    public static void PrintArrayReversed(int[] array, int index)
    {
        // Базовый случай: если индекс меньше 0, значит мы достигли начала массива
        if (index < 0)
        {
            return;
        }

        // Выводим элемент массива с текущим индексом
        Console.WriteLine(array[index]);

        // Рекурсивно вызываем функцию для предыдущего элемента массива
        PrintArrayReversed(array, index - 1);
    }
} 

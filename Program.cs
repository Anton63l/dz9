// Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// string NumbersRec(int a, int b)
// {
//     if (a>=b) return $"{a} " + NumbersRec(a-1,b);
//     else return String.Empty;
// }

// System.Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(NumbersRec(n,1));

// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// int SumMN(int a, int b)
// {
//     if (a == b) return a;
//     else return a + SumMN(a + 1, b);

// }

// System.Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(SumMN(m, n));

// Задача 3: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else if (n == 0 && m > 0)
//     {
//         return Akkerman(m - 1, 1);
//     }
//     else
//     {
//         return (Akkerman(m - 1, Akkerman(m, n - 1)));
//     }
// }

// Console.Write("Введите число M: ");
// int m = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите число N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Write(Akkerman(m, n)); 

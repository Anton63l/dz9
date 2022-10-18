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


int SumMN(int a, int b)
{
    if (a == b) return a;
    else return a + SumMN(a + 1, b);

}

System.Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(SumMN(m, n));

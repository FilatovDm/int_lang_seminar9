/*
Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N (+ их сумму).
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

Console.Write("Введите значение M: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

int GetSumNumbers(int m, int n)
{
    if (n == m)
    {
        return m;
    }

    int sum = n + GetSumNumbers(m, n - 1);
    return sum;
}

string GetNaturalNumbers(int m, int n)
{
    if (n == m)
    {
        return $"{m}";
    }
    string result = GetNaturalNumbers(m, n - 1) + " " + n;
    return result;
}

int result = GetSumNumbers(m, n);
Console.WriteLine("Сумма элементов " + result);

string naturalNumbers = GetNaturalNumbers(m, n);
Console.WriteLine(naturalNumbers);
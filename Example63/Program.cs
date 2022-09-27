/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N и их суммы.
N = 5 -> "1, 2, 3, 4, 5" сумма 15
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

Console.Write("Введите значение N: ");
int n = int.Parse(Console.ReadLine());

int GetSumNumbers(int n)
{
    if (n == 0)
    {
        return 0;
    }

    int sum = n + GetSumNumbers(n -1);
    return sum;
}

string GetNaturalNumbers(int n)
{
    if (n == 1)
    {
        return "1";
    }
    string result = GetNaturalNumbers(n - 1) + " " + n;
    return result;
}

int result = GetSumNumbers(n);
Console.WriteLine("Сумма элементов " + result);

string naturalNumbers = GetNaturalNumbers(n);
Console.WriteLine(naturalNumbers);

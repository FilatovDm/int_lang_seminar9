/*
Задача 69: Напишите программу, которая на вход принимает два 
числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

/*
int func(int m ,int n ) 
{
    int funnyc( int m ,int n ,int p)
    {
        if(n!=1)
        {
        m = m * p ;
        funnyc(m,n-1,p);
        return m;
        }
        else
        {
            System.Console.WriteLine(m);
            return m;
        }
    }

    int p1 = m;

    return funnyc(m,n,p1);

}

System.Console.WriteLine(func(4, 8));
*/

int GetDegreeNumber(int a, int b)
{
    if (b == 1)
    {
        return a;
    }
    int result = a * GetDegreeNumber(a, b - 1);
    return result;
}


Console.Write("Введите значение A: ");
int a = int.Parse(Console.ReadLine());

Console.Write("Введите значение B: ");
int b = int.Parse(Console.ReadLine());

int resultDegree = GetDegreeNumber(a, b);
Console.WriteLine(resultDegree);
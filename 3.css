using System;

class Program
{
    // Находим наибольший общий делитель
    static int FindGCD(int a, int b)
    {
        // Алгоритм Евклида
        while (b != 0)
        {
            int temp = b;
            b = a % b;  // Остаток от деления
            a = temp;
        }
        return a;
    }

    static void Main()
    {
        Console.Write("Введите числитель M: ");
        int m = int.Parse(Console.ReadLine());
        
        Console.Write("Введите знаменатель N: ");
        int n = int.Parse(Console.ReadLine());

        // Находим НОД
        int gcd = FindGCD(m, n);

        // Делим на НОД
        int newM = m / gcd;
        int newN = n / gcd;

        Console.WriteLine("Сокращенная дробь: " + newM + "/" + newN);
    }
}

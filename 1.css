using System;

class Program
{
    // Функция для вычисления факториала
    static double Factorial(int n)
    {
        double result = 1;
        for (int i = 1; i <= n; i++)
        {
            result = result * i;  // Умножаем 1*2*3*...*n
        }
        return result;
    }

    // Функция для вычисления одного члена ряда
    static double CalculateTerm(double x, int n)
    {
        // Член ряда = x^n / n!
        double term = Math.Pow(x, n) / Factorial(n);
        return term;
    }

    // Функция для вычисления суммы ряда
    static double CalculateSum(double x, double precision)
    {
        double sum = 0;          // Сумма ряда
        double term = 1;         // Текущий член ряда
        int n = 0;               // Номер члена

        // Пока член ряда больше точности, продолжаем
        while (Math.Abs(term) > precision)
        {
            sum = sum + term;    // Добавляем член к сумме
            n = n + 1;           // Увеличиваем номер
            term = CalculateTerm(x, n);  // Считаем следующий член
        }
        return sum;
    }

    static void Main()
    {
        // Ввод данных
        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите точность (меньше 0.01): ");
        double e = double.Parse(Console.ReadLine());

        // Проверка точности
        if (e >= 0.01)
        {
            Console.WriteLine("Точность должна быть меньше 0.01!");
            return;
        }

        // Считаем сумму ряда
        double result = CalculateSum(x, e);
        Console.WriteLine("Результат: " + result);

        // Считаем n-й член
        Console.Write("Введите номер члена n: ");
        int n = int.Parse(Console.ReadLine());
        double nthTerm = CalculateTerm(x, n);
        Console.WriteLine(n + "-й член: " + nthTerm);
    }
}

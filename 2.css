using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите номер билета (6 цифр): ");
        string ticket = Console.ReadLine();

        // Проверяем что ввели 6 цифр
        if (ticket.Length != 6)
        {
            Console.WriteLine("Нужно ввести 6 цифр!");
            return;
        }

        // Превращаем символы в цифры
        int digit1 = ticket[0] - '0';
        int digit2 = ticket[1] - '0';
        int digit3 = ticket[2] - '0';
        int digit4 = ticket[3] - '0';
        int digit5 = ticket[4] - '0';
        int digit6 = ticket[5] - '0';

        // Сумма первых трех цифр
        int sum1 = digit1 + digit2 + digit3;
        // Сумма последних трех цифр
        int sum2 = digit4 + digit5 + digit6;

        // Сравниваем суммы
        if (sum1 == sum2)
        {
            Console.WriteLine("Счастливый билет!");
        }
        else
        {
            Console.WriteLine("Обычный билет");
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        int min = 0;
        int max = 63;
        int number = 0;

        Console.WriteLine("Загадайте число от 0 до 63");
        Console.WriteLine("Отвечайте 1 (да) или 0 (нет)");

        // Проверяем каждый разряд числа
        for (int i = 5; i >= 0; i--)
        {
            int question = min + (1 << i);  // Число для вопроса
            Console.Write("Ваше число больше или равно " + question + "? ");
            string answer = Console.ReadLine();

            if (answer == "1")
            {
                number = number + (1 << i);  // Устанавливаем бит
                min = question;              // Сдвигаем минимум
            }
            else
            {
                max = question - 1;          // Сдвигаем максимум
            }
        }

        Console.WriteLine("Вы загадали число: " + number);
    }
}

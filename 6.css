using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество бактерий: ");
        int bacteria = int.Parse(Console.ReadLine());
        
        Console.Write("Введите количество капель антибиотика: ");
        int drops = int.Parse(Console.ReadLine());

        int power = drops * 10;  // Начальная сила
        int hour = 0;

        Console.WriteLine("\nЧас | Бактерий | Сила антибиотика");
        Console.WriteLine("--------------------------------");

        // Пока антибиотик действует
        while (power > 0)
        {
            hour++;
            
            // Сначала бактерии размножаются
            bacteria = bacteria * 2;
            
            // Потом действует антибиотик
            bacteria = bacteria - power;
            
            // Сила антибиотика уменьшается
            power = power - drops;
            
            // Не может быть меньше 0 бактерий
            if (bacteria < 0) bacteria = 0;

            // Выводим результат часа
            Console.WriteLine(hour + "   | " + bacteria + "       | " + power);

            // Если бактерий не осталось - заканчиваем
            if (bacteria == 0) break;
        }

        Console.WriteLine("\nИтог: " + bacteria + " бактерий за " + hour + " часов");
    }
}

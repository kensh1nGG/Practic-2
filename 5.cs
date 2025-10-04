using System;

class Program
{
    static void Main()
    {
        // Ввод начальных запасов
        Console.Write("Сколько мл воды? ");
        int water = int.Parse(Console.ReadLine());
        
        Console.Write("Сколько мл молока? ");
        int milk = int.Parse(Console.ReadLine());

        int americanoCount = 0;
        int latteCount = 0;
        bool working = true;

        while (working)
        {
            // Выбор напитка
            Console.WriteLine("\nКакой напиток?");
            Console.WriteLine("1 - Американо (300 мл воды)");
            Console.WriteLine("2 - Латте (30 мл воды + 270 мл молока)");
            Console.Write("Ваш выбор: ");
            
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)  // Американо
            {
                if (water >= 300)
                {
                    water = water - 300;
                    americanoCount++;
                    Console.WriteLine("Ваш американо готов! 150 руб");
                }
                else
                {
                    Console.WriteLine("Не хватает воды!");
                }
            }
            else if (choice == 2)  // Латте
            {
                if (water >= 30 && milk >= 270)
                {
                    water = water - 30;
                    milk = milk - 270;
                    latteCount++;
                    Console.WriteLine("Ваш латте готов! 170 руб");
                }
                else
                {
                    Console.WriteLine("Не хватает ингредиентов!");
                }
            }

            // Проверяем можно ли сделать еще что-то
            bool canMakeAmericano = water >= 300;
            bool canMakeLatte = water >= 30 && milk >= 270;
            
            if (!canMakeAmericano && !canMakeLatte)
            {
                working = false;
                Console.WriteLine("\n--- ОТЧЕТ ---");
                Console.WriteLine("Осталось воды: " + water + " мл");
                Console.WriteLine("Осталось молока: " + milk + " мл");
                Console.WriteLine("Американо продано: " + americanoCount);
                Console.WriteLine("Латте продано: " + latteCount);
                
                int money = americanoCount * 150 + latteCount * 170;
                Console.WriteLine("Всего заработано: " + money + " руб");
            }
        }
    }
}

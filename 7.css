using System;

class Program
{
    // Проверяем поместятся ли модули
    static bool CanPlace(int n, int a, int b, int h, int w, int d)
    {
        // Размер модуля с защитой
        int widthWithShield = a + 2 * d;
        int heightWithShield = b + 2 * d;

        // Пробуем разместить обычным способом
        int fit1 = (h / widthWithShield) * (w / heightWithShield);
        
        // Пробуем разместить повернутыми
        int fit2 = (h / heightWithShield) * (w / widthWithShield);

        // Если хотя бы один способ подходит
        return fit1 >= n || fit2 >= n;
    }

    static void Main()
    {
        // Ввод данных
        Console.Write("Количество модулей n: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.Write("Размер модуля a b: ");
        string[] sizes = Console.ReadLine().Split();
        int a = int.Parse(sizes[0]);
        int b = int.Parse(sizes[1]);
        
        Console.Write("Размер поля w h: ");
        sizes = Console.ReadLine().Split();
        int w = int.Parse(sizes[0]);
        int h = int.Parse(sizes[1]);

        int maxD = 0;
        int currentD = 0;

        // Пробуем увеличивать защиту пока помещается
        while (true)
        {
            if (CanPlace(n, a, b, h, w, currentD))
            {
                maxD = currentD;
                currentD++;  // Пробуем больше
            }
            else
            {
                break;  // Уже не помещается - заканчиваем
            }
        }

        if (maxD == 0 && !CanPlace(n, a, b, h, w, 0))
        {
            Console.WriteLine("Нельзя разместить даже без защиты!");
        }
        else
        {
            Console.WriteLine("Максимальная толщина защиты: " + maxD);
        }
    }
}

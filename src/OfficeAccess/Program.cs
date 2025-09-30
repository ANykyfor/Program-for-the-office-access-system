using System;
using System.Collections.Generic;

enum DayPart { Morning, Day, Evening, Night }

static class Program
{
    static void Main()
    {
        Console.InputEncoding  = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Введіть рівень доступу (1-5): ");
        if (!int.TryParse(Console.ReadLine(), out int level) || level < 1 || level > 5)
        {
            Console.WriteLine("Некоректний рівень доступу, маєте ще є декілька спроб , в інакшому випадку я дістаю Кольт.");
            return;
        }
        Console.WriteLine("Введіть час доби (ранок/день/вечір/ніч):  ");
        var timeRaw = (Console.ReadLine() ?? "").Trim().ToLowerInvariant();
         if (!TryParseDayPart(timeRaw, out var part))
        {
            Console.WriteLine("Помилка: некоректний час доби.");
            return;
        }
        switch (level)
        {
            case 1:
                Console.WriteLine(part == DayPart.Day ? "Доступ дозволено : зона - хол." : "Доступ заборонено.");
                break;
            case 2:
                Console.WriteLine((part == DayPart.Morning || part == DayPart.Day) ? "Доступ дозволено: зони - хол, робочі зали." : "Доступ заборонено.");
                break;
    












   }
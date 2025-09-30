using System;
using System.Collections.Generic;

enum DayPart { Morning, Day, Evening, Night }

static class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть рівень доступу (1-5):  ");
        if (!int.TryParse(Console.ReadLine(), out int level) || level < 1 || level > 5)
        {
            System.Console.WriteLine("Некоректний рівень доступу, у вас ще є декілька спроб , в інакшому випадку я дістаю Кольт.");
            return;
        }
        System.Console.WriteLine("Введіть час доби (ранок/день/вечір/ніч):  ");
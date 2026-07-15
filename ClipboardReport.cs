using System;
using System.Collections.Generic;

public static class ClipboardReport
{
    public static void Print(List<ClipboardItem> items)
    {
        Console.WriteLine("Clipboard History");
        Console.WriteLine("-------------------------");

        int i = 1;

        foreach (var item in items)
        {
            Console.WriteLine($"{i++}. {item.Content}");
        }

        Console.WriteLine();

        Console.WriteLine($"Items : {items.Count}");
        Console.WriteLine($"Capacity : {AppSettings.MaxHistory}");
    }
}

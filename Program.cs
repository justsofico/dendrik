using System;

var store = new ClipboardStore();

SampleHistory.Load(store);

ClipboardReport.Print(store.All());

Console.WriteLine();

Console.WriteLine("Search: notes");

Console.WriteLine();

var result = ClipboardSearch.Find(
    store.All(),
    "notes"
);

foreach (var item in result)
{
    Console.WriteLine(item.Content);
}

Console.WriteLine();

store.Remove("Shopping list");

Console.WriteLine("After removing one entry:");

Console.WriteLine();

ClipboardReport.Print(store.All());

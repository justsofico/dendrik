# Clipboard History Analyzer

Clipboard History Analyzer is a small C# console application that simulates a clipboard manager.

Instead of storing only the last copied text, it keeps a history of clipboard entries, supports searching, deleting items and displaying storage statistics.

---

## Preview

```
Clipboard History

Stored Items

1. https://github.com
2. Meeting notes
3. SSH private key
4. Shopping list

Search: notes

Result

Meeting notes

Storage

Items : 4
Capacity : 1000
```

---

## Components

ClipboardStore.cs

Stores clipboard entries.

ClipboardSearch.cs

Search engine.

ClipboardReport.cs

Displays statistics.

ClipboardItem.cs

Clipboard model.

SampleHistory.cs

Demo records.

---

## Start

```
dotnet run
```

---

Designed as a learning project using .NET 8.

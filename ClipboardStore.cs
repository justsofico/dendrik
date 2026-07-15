using System.Collections.Generic;

public class ClipboardStore
{
    private readonly List<ClipboardItem> items = new();

    public void Add(ClipboardItem item)
    {
        if (items.Count >= AppSettings.MaxHistory)
            items.RemoveAt(0);

        items.Add(item);
    }

    public void Remove(string content)
    {
        items.RemoveAll(x => x.Content == content);
    }

    public List<ClipboardItem> All()
    {
        return items;
    }
}

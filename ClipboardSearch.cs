using System.Collections.Generic;
using System.Linq;

public static class ClipboardSearch
{
    public static List<ClipboardItem> Find(
        IEnumerable<ClipboardItem> items,
        string keyword)
    {
        return items
            .Where(x =>
                x.Content.Contains(
                    keyword,
                    StringComparison.OrdinalIgnoreCase))
            .ToList();
    }
}

public class ClipboardItem
{
    public string Content { get; }

    public DateTime Created { get; }

    public ClipboardItem(string content)
    {
        Content = content;
        Created = DateTime.Now;
    }
}

public static class SampleHistory
{
    public static void Load(ClipboardStore store)
    {
        store.Add(new ClipboardItem("https://github.com"));

        store.Add(new ClipboardItem("Meeting notes"));

        store.Add(new ClipboardItem("SSH private key"));

        store.Add(new ClipboardItem("Shopping list"));

        store.Add(new ClipboardItem("Docker command"));
    }
}

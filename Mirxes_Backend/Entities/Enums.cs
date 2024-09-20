public enum ItemName
{
    Item1,
    Item2,
    Item3
}

public static class ItemNameExtensions
{
    private static readonly Dictionary<ItemName, string> ItemNameMappings = new()
    {
        { ItemName.Item1, "DF07-0001" },
        { ItemName.Item2, "DF07-0002" },
        { ItemName.Item3, "DF07-0003" }
    };

    public static string GetItemCode(this ItemName itemName)
    {
        return ItemNameMappings.TryGetValue(itemName, out var code) ? code : null;
    }
}

namespace Skyrim;

internal class ItemContainer : GameItem
{    
    public List<GameItem> GameItems { get; set; }

    public ItemContainer(string name, List<GameItem> gameItems)
    {
        Name = name;
        GameItems = gameItems;
    }
}

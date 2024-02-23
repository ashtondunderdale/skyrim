namespace Skyrim;

internal class ItemContainer : GameItem
{    
    public List<GameItem> GameItems { get; set; }

    public ItemContainer(List<GameItem> gameItems) 
    { 
        GameItems = gameItems;
    }
}

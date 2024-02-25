namespace Skyrim;

internal class Scene
{
    public List<GameItem> Objects { get; set; }

    public static Scene HelgenKeep { get; }

    static Scene()
    {
        HelgenKeep = new Scene
        {
            Objects = new List<GameItem>
            {
                new ItemContainer("Chest", new List<GameItem>
                {
                    new Weapon("Iron Sword", 7, 9, 25),
                    new Apparel("Imperial Light Armor", 23, 6, 75),
                    new Apparel("Imperial Light Boots", 6, 2, 5),
                }),

                new Weapon("Iron Sword", 7, 9, 25),
                new Apparel("Imperial Light Armor", 23, 6, 75),

                new ItemContainer("Chest", new List<GameItem>
                {
                    new Apparel("Imperial Light Boots", 6, 2, 5),
                }),

                new Apparel("Imperial Light Helmet", 11, 2, 75),
            }
        };
    }
}

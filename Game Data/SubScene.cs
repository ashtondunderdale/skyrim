namespace Skyrim;

internal class SubScene
{
    public List<GameItem>? Objects { get; set; }
    public string? Name { get; set; }

    public static SubScene HelgenKeepBarracks { get; }
    public static SubScene HelgenKeepStorageRoom { get; }
    public static SubScene HelgenKeepDungeon { get; }

    static SubScene()
    {
        HelgenKeepBarracks = new SubScene
        {
            Name = "HelgenKeepBarracks",

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

        HelgenKeepStorageRoom = new SubScene
        {
            Name = "HelgenKeepStorageRoom",

            Objects = new List<GameItem>
            {
                new ItemContainer("Barrel", new List<GameItem>
                {
                    new Weapon("Iron Sword", 7, 9, 25),
                }),

                new Weapon("Iron Sword", 7, 9, 25),
                new Apparel("Imperial Light Helmet", 11, 2, 75),
            }
        };

        HelgenKeepDungeon = new SubScene
        {
            Name = "HelgenKeepDungeon",

            Objects = new List<GameItem>
            {
                new ItemContainer("Barrel", new List<GameItem>
                {
                    new Weapon("Iron Sword", 7, 9, 25),
                    new Weapon("Iron Sword", 7, 9, 25),
                    new Apparel("Imperial Light Armor", 23, 6, 75),
                    new Weapon("Iron Sword", 7, 9, 25),
                }),

                new Weapon("Iron Sword", 7, 9, 25),
                new Apparel("Imperial Light Helmet", 11, 2, 75),
            }
        };
    }
}

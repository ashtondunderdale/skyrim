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
                    Weapon.IronSword,
                    Apparel.ImperialLightArmor,
                    Apparel.ImperialLightBoots,
                }),

                Weapon.IronSword,
                Apparel.ImperialLightArmor,

                new ItemContainer("Chest", new List<GameItem>
                {
                    Apparel.ImperialLightBoots,
                }),

                Apparel.ImperialLightHelmet,
            }
        };
    }
}

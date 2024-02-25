namespace Skyrim;

internal class Apparel : GameItem
{
    public int Armor { get; set; }

    public static Apparel ImperialLightArmor { get; } = new Apparel { Name = "Imperial Light Armor", Armor = 23, Weight = 6, Value = 75 };

    public static Apparel ImperialLightBoots { get; } = new Apparel { Name = "Imperial Light Boots", Armor = 6, Weight = 2, Value = 15 };
    
    public static Apparel ImperialLightHelmet { get; } = new Apparel { Name = "Imperial Light Helmet", Armor = 11, Weight = 2, Value = 35 };
}
namespace Skyrim;

internal class Apparel : GameItem
{
    public int Armor { get; set; }

    public static Apparel ImperialLightArmor { get; } = new Apparel { Name = "Imperial Light Armor", Armor = 23, Weight = 6, Value = 75 };
}
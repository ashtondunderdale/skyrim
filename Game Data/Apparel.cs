namespace Skyrim;

internal class Apparel : GameItem
{
    public int Armor { get; set; }

    public Apparel(string name, int armor, int weight, int value)
    {
        Name = name;
        Armor = armor;
        Weight = weight;
        Value = value;
    }

    public static Apparel ImperialLightArmor { get; } = new Apparel("Imperial Light Armor", 23, 6, 75);
    public static Apparel ImperialLightBoots { get; } = new Apparel("Imperial Light Boots", 6, 2, 5);
    public static Apparel ImperialLightHelmet { get; } = new Apparel("Imperial Light Helmet", 11, 2, 75);

    public static Apparel CreateNewInstance(Apparel apparel)
    {
        return new Apparel(apparel.Name, apparel.Armor, apparel.Weight, apparel.Value);
    }
}

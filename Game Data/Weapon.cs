namespace Skyrim;

internal class Weapon : GameItem
{
    public int Damage { get; set; }

    public Weapon(string name, int damage, int weight, int value)
    {
        Name = name;
        Damage = damage;
        Weight = weight;
        Value = value;
    }

    public static Weapon IronSword { get; } = new Weapon("Iron Sword", 7, 9, 25);

    public static Weapon CreateNewInstance(string name, int damage, int weight, int value)
    {
        return new Weapon(name, damage, weight, value);
    }
}

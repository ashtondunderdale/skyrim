namespace Skyrim;

internal class Weapon : GameItem
{
    public int Damage { get; set; }

    public static Weapon IronSword { get; } = new Weapon { Name = "Iron Sword", Damage = 7, Weight = 9, Value = 25 };
}
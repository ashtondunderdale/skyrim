namespace Skyrim;

internal class Player
{
    public readonly Race Race;

    public string Name { get; set; }

    public int Level { get; set; }

    public int Health { get; set; }

    public int Stamina { get; set; }

    public int Magicka { get; set; }

    public List<GameItem> Inventory = new();

    public Player(string name, Race race) 
    {
        Name = name;
        Race = race;
        Health = race.Health; 
        Stamina = race.Stamina;
        Magicka = race.Magicka;
    }

    // LeftHandEquip / RightHandEquip
    // Head, Body, Arms, Boots, Ring, Necklace, Gloves, Equip
}

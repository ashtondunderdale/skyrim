using Skyrim;

namespace Skyrim;

internal class Player
{
    public readonly Race Race;

    string Name { get; set; }

    int Level { get; set; }

    int Health { get; set; }

    int Stamina { get; set; }

    int Magicka { get; set; }

    Scene? Scene { get; set; }

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

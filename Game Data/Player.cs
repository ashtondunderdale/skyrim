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

    public double InventoryWeight;

    public double MaxWeight;

    public Player(string name, Race race) 
    {
        Name = name;
        Race = race;

        Health = race.Health; 
        Stamina = race.Stamina;
        Magicka = race.Magicka;

        MaxWeight = 20;
    }

    // LeftHandEquip / RightHandEquip
    // Head, Body, Arms, Boots, Ring, Necklace, Gloves, Equip

    public double CalculateInventoryWeight() 
    {
        double totalWeight = 0;

        foreach (GameItem item in Inventory) 
        {
            totalWeight += item.Weight;
        }

        return totalWeight;
    }
}

namespace Skyrim;

internal class Player
{
    public readonly Race Race;

    public string Name { get; set; }

    public int Level { get; set; }

    public double Experience { get; set; }

    public int Health { get; set; }

    public int Stamina { get; set; }

    public int Magicka { get; set; }

    public List<GameItem> Inventory = new();

    public double InventoryWeight { get; set; }

    public double MaxWeight { get; set; }

    public GameItem? LeftHandEquip { get; set; }

    public GameItem? RightHandEquip { get; set; }

    public GameItem? HeadEquip { get; set; }

    public GameItem? BodyEquip { get; set; }

    public GameItem? ArmsEquip { get; set; }

    public GameItem? BootsEquip { get; set; }

    public GameItem? GlovesEquip { get; set; }

    public Player(string name, Race race) 
    {
        Name = name;
        Race = race;

        Health = race.Health; 
        Stamina = race.Stamina;
        Magicka = race.Magicka;

        Experience = 0;
        Level = 1;
        MaxWeight = 300;
    }

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

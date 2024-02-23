namespace skyrim;

internal class Race
{
    public string Name { get; set; }
    public string Description { get; set; }

    public int Health = 100;

    public int Stamina = 100;
    public int Magicka = 100;
    public int Smithing { get; set; }
    public int HeavyArmour { get; set; }
    public int Block { get; set; }
    public int TwoHanded { get; set; }
    public int OneHanded { get; set; }
    public int Archery { get; set; }
    public int LightArmor { get; set; }
    public int Sneak { get; set; }
    public int Lockpicking { get; set; }
    public int Pickpocket { get; set; }
    public int Speech { get; set; }
    public int Alchemy { get; set; }
    public int Illusion { get; set; }
    public int Conjuration { get; set; }
    public int Destruction { get; set; }
    public int Restoration { get; set; }
    public int Alteration { get; set; }
    public int Enchantment { get; set; }

    public static List<Race> Races { get; } = new List<Race>
    {
        new Race { 
            Name = "Altmer", 
            Description = "Known as \"Altmer\" in their homeland of Summerset Isle, the High Elves are the most gifted " +
            "in the arcane arts of all the races. They can call upon their Highborn power to regenerate Magicka quickly.",

            Magicka = 150, // yeah i know 

            Smithing = 15,
            HeavyArmour = 15,
            Block = 15,
            TwoHanded = 15,
            OneHanded = 15,
            Archery = 15,
            LightArmor = 15,
            Sneak = 15,
            Lockpicking = 15,
            Pickpocket = 15,
            Speech = 15,
            Alchemy = 15,
            Illusion = 25,
            Conjuration = 20,
            Destruction = 20,
            Restoration = 20,
            Alteration = 20,
            Enchantment = 20,
        },

        new Race { 
            Name = "Argonian",

            Smithing = 15,
            HeavyArmour = 15,
            Block = 15,
            TwoHanded = 15,
            OneHanded = 15,
            Archery = 15,
            LightArmor = 20,
            Sneak = 20,
            Lockpicking = 25,
            Pickpocket = 20,
            Speech = 15,
            Alchemy = 15,
            Illusion = 15,
            Conjuration = 15,
            Destruction = 15,
            Restoration = 20,
            Alteration = 20,
            Enchantment = 15,
        },

        new Race {
            Name = "Bosmer",

            Smithing = 15,
            HeavyArmour = 15,
            Block = 15,
            TwoHanded = 15,
            OneHanded = 15,
            Archery = 25,
            LightArmor = 20,
            Sneak = 20,
            Lockpicking = 20,
            Pickpocket = 20,
            Speech = 15,
            Alchemy = 20,
            Illusion = 15,
            Conjuration = 15,
            Destruction = 15,
            Restoration = 15,
            Alteration = 15,
            Enchantment = 15,
        },

        new Race {
            Name = "Breton",

            Smithing = 15,
            HeavyArmour = 15,
            Block = 15,
            TwoHanded = 15,
            OneHanded = 15,
            Archery = 15,
            LightArmor = 15,
            Sneak = 15,
            Lockpicking = 15,
            Pickpocket = 15,
            Speech = 20,
            Alchemy = 20,
            Illusion = 20,
            Conjuration = 25,
            Destruction = 15,
            Restoration = 20,
            Alteration = 20,
            Enchantment = 15,
        }

        new Race {
            Name = "Dunmer",

            Smithing = 15,
            HeavyArmour = 15,
            Block = 15,
            TwoHanded = 15,
            OneHanded = 15,
            Archery = 15,
            LightArmor = 20,
            Sneak = 20,
            Lockpicking = 15,
            Pickpocket = 15,
            Speech = 15,
            Alchemy = 20,
            Illusion = 20,
            Conjuration = 15,
            Destruction = 25,
            Restoration = 15,
            Alteration = 20,
            Enchantment = 15,
        },

        new Race {
            Name = "Imperial",

            Smithing = 15,
            HeavyArmour = 20,
            Block = 20,
            TwoHanded = 15,
            OneHanded = 20,
            Archery = 15,
            LightArmor = 15,
            Sneak = 15,
            Lockpicking = 15,
            Pickpocket = 15,
            Speech = 15,
            Alchemy = 15,
            Illusion = 15,
            Conjuration = 15,
            Destruction = 20,
            Restoration = 25,
            Alteration = 15,
            Enchantment = 20,
        },

        new Race {
            Name = "Khajiit",

            Smithing = 15,
            HeavyArmour = 15,
            Block = 15,
            TwoHanded = 15,
            OneHanded = 20,
            Archery = 20,
            LightArmor = 15,
            Sneak = 25,
            Lockpicking = 20,
            Pickpocket = 20,
            Speech = 15,
            Alchemy = 20,
            Illusion = 15,
            Conjuration = 15,
            Destruction = 15,
            Restoration = 15,
            Alteration = 15,
            Enchantment = 15,
        },

        new Race {
            Name = "Nord",

            Smithing = 20,
            HeavyArmour = 15,
            Block = 20,
            TwoHanded = 25,
            OneHanded = 20,
            Archery = 15,
            LightArmor = 20,
            Sneak = 15,
            Lockpicking = 15,
            Pickpocket = 15,
            Speech = 20,
            Alchemy = 15,
            Illusion = 15,
            Conjuration = 15,
            Destruction = 15,
            Restoration = 15,
            Alteration = 15,
            Enchantment = 15,
        },

        new Race {
            Name = "Orsimer",

            Smithing = 20,
            HeavyArmour = 25,
            Block = 20,
            TwoHanded = 20,
            OneHanded = 20,
            Archery = 15,
            LightArmor = 15,
            Sneak = 15,
            Lockpicking = 15,
            Pickpocket = 15,
            Speech = 15,
            Alchemy = 15,
            Illusion = 15,
            Conjuration = 15,
            Destruction = 15,
            Restoration = 15,
            Alteration = 15,
            Enchantment = 20,
        },

        new Race {
            Name = "Redguard",

            Smithing = 20,
            HeavyArmour = 15,
            Block = 120,
            TwoHanded = 15,
            OneHanded = 25,
            Archery = 20,
            LightArmor = 15,
            Sneak = 15,
            Lockpicking = 15,
            Pickpocket = 15,
            Speech = 15,
            Alchemy = 15,
            Illusion = 15,
            Conjuration = 15,
            Destruction = 20,
            Restoration = 15,
            Alteration = 20,
            Enchantment = 15,
        },
    };
}

namespace skyrim;

internal class Race
{
    public string? Name { get; set; }
    public string? Description { get; set; }

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
            Description = "The high elves, also called Altmer, excel in arcane arts and can swiftly regenerate Magicka with their Highborn ability.\r\n\r\n\r\n",

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
            Description = "Argonians, native to Black Marsh, resist diseases, breathe underwater, and quickly regenerate health",

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

            Description = "From Western Valenwood, the Wood Elves, or Bosmer, are skilled scouts and archers. They resist poisons and diseases and can Command Animals.\r\n\r\n\r\n\r\n\r\n\r\n\r\n",

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

            Description = "Bretons from High Rock are skilled in spellcraft and possess innate magic resistance. They can absorb spells using Dragonskin.",

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
        },

        new Race {
            Name = "Dunmer",

            Description = "Dark elves, or Dunmer, are adept in stealth and magic, resistant to fire, and can envelop themselves in flames with Ancestor's Wrath.",

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

            Description = "Cyrodiil's Imperials excel in diplomacy, trade, combat, and magic. They possess a unique ability to charm enemies with the Voice of the Emperor.\r\n\r\n\r\n\r\n\r\n\r\n",

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

            Description = "From Elsweyr, Khajiit are intelligent, agile thieves, able to see in the dark at will and attack with their claws.\r\n\r\n\r\n\r\n\r\n\r\n",

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

            Description = "Skyrim's inhabitants, Nords are tall, fair-haired, and resilient to cold. Renowned as skilled warriors, they can use a Battlecry to intimidate foes.\r\n\r\n\r\n\r\n\r\n\r\n",

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

            Description = "Orcs, renowned for their craftsmanship and battle prowess, hail from the rugged Wrothgarian and Dragontail Mountains.\r\n\r\n\r\n\r\n\r\n\r\n",

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

            Description = "Hammerfell's Redguards, highly skilled fighters, are immune to poison and can trigger an Adrenaline Rush in battle.\r\n\r\n\r\n\r\n\r\n",

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

namespace Skyrim;

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
            Name = "High Elf", 
            Description = "Also known as \"Altmer\" in their homeland of Summerset Isle, the high elves are the most strongly gifted in the arcane arts of all the races. They can call upon their Highborn power to regenerate Magicka quickly.",

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
            Description = "This reptilian race, well-suited for the treacherous swamps of their Black Marsh homeland, has developed a natural resistance to diseases and the ability to breathe underwater. They can call upon the Histskin to regenerate health very quickly.",

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
            Name = "Wood Elf",

            Description = "The clanfolk of the Western Valenwood forests, also known as \"Bosmer.\" Wood elves make good scouts and thieves, and there are no finer archers in all of Tamriel. They have natural resistances to both poisons and diseases. They can Command Animals to fight for them.",

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

            Description = "In addition to their quick and perceptive grasp of spellcraft, even the humblest of High Rock's Bretons can boast a resistance to magic. Bretons can call upon the Dragonskin power to absorb spells.",

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
            Name = "Dark Elf",

            Description = "Also known as \"Dunmer\" in their homeland of Morrowind, dark elves are noted for their stealth and magic skills. They are naturally resistant to fire and can call upon their Ancestor's Wrath to surround themselves in fire.",

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

            Description = "Natives of Cyrodiil, they have proved to be shrewd diplomats and traders. They are skilled with combat and magic. Anywhere gold coins might be found, Imperials always seem to find a few more. They can call upon the Voice of the Emperor to calm an enemy.",

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

            Description = "Hailing from the province of Elsweyr, they are intelligent, quick, and agile. They make excellent thieves due to their natural stealthiness. All Khajiit can see in the dark at will and have unarmed claw attacks.",

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

            Description = "Citizens of Skyrim, they are a tall and fair-haired people. Strong and hardy, Nords are famous for their resistance to cold and their talent as warriors. They can use a Battlecry to make opponents flee.",

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
            Name = "Orc",

            Description = "The people of the Wrothgarian and Dragontail Mountains, Orcish smiths are prized for their craftsmanship. Orc troops in Heavy Armor are among the finest in the Empire, and are fearsome when using their Berserker Rage.",

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

            Description = "The most naturally talented warriors in Tamriel, the Redguards of Hammerfell have a hardy constitution and a natural resistance to poison. They can call upon an Adrenaline Rush in combat.",

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

internal class Data
{
    public const string SKYRIM_LOGO = "                                                            \r\n                                                            \r\n                          @.    :@                          \r\n                         @: -    =@                         \r\n                        @@  @#=   @@                        \r\n                       %@: .@  %  +@=                       \r\n                      =@@      :-  @@.                      \r\n                     .@@*:  +@-   :@@@                      \r\n                     @=@    @.      @=@                     \r\n                    @+@@  #=@@@ +#  @@-@                    \r\n                    *@@@%--*@@@@=*=@@*@-                    \r\n                     #@@@=@@@@@@@@+@@@+                     \r\n                      @@@  +=@@%*  @@#                      \r\n                       @@     @    @@                       \r\n                        @%    @.  @@                        \r\n                         @@  :@  @@                         \r\n                         :@ .@   @                          \r\n                          +  @                              \r\n                            +                               \r\n                            %                               \r\n                             @@                             \r\n                                                            \r\n                                                          ";
    public const string DRAGON_ASCII = "                                               \r\n                                               \r\n                                               \r\n   @@@         @        @                      \r\n     #@@@@@=+* @@      @@         @            \r\n       -  *@@@@@@      @        @@==# .=%@@@@  \r\n       @   %-@@@@*     @      @@@@@@@@@@@      \r\n      @@@@@- . ##@    .@      @@=%@+   @       \r\n          .:: @: .@@@@@=@@@*@@ = :*%@@@@       \r\n             @=-@@@@ @.-  @@@@# @ ::           \r\n            .-        @@@        @             \r\n                     @@@@                      \r\n                      -@@                      \r\n                      @ @                      \r\n                        @                      \r\n                        @                      \r\n                       @*                      \r\n                      %#                       \r\n                      @                        \r\n                      @                        \r\n                      @                        \r\n                       @                     ";
}

internal class Items 
{ 

}
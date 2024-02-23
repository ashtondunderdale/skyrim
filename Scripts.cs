using System.Media;

namespace Skyrim;

internal class Scripts
{
    const string NPC_RALOF = "Ralof";
    const string NPC_LOKIR = "Lokir";
    const string NPC_IMPERIAL_SOLDIER = "Imperial Soldier";
    const string NPC_GENERAL_TULLIUS = "General Tullius";
    const string NPC_HAMING = "Haming";
    const string NPC_TOROLF = "Torolf";
    const string NPC_IMPERIAL_CAPTAIN = "Imperial Captain";
    const string NPC_HADVAR = "Hadvar";

    public const ConsoleColor CONTEXTCOLOUR = ConsoleColor.DarkGray;
    public const ConsoleColor BASECOLOUR = ConsoleColor.White;

    public static void PlayIntroScript()
    {
        Clear();

        Sleep(5);
        PlayIntroMusic();

        Sleep(17);

        PrintDialogueContext("\tThe Elder Scrolls V");
        Sleep(11);
        Clear();

        Console.ForegroundColor = BASECOLOUR;
        Console.WriteLine("\n\n\t\tSkyrim");
        Sleep(7);
        Clear();

        Sleep(5);


        Console.ForegroundColor = CONTEXTCOLOUR;
        Console.Write("You awake on an Imperial wagon driving four prisoners down a snowy mountain pass.\n\n");
        Console.ForegroundColor = BASECOLOUR;
        Sleep(5);

        PrintDialogue(NPC_RALOF, "Hey, you. You're finally awake. You were trying to cross the border, right? Walked right into that Imperial ambush, same as us, and that thief over there.");
        Sleep(3);

        PrintDialogue(NPC_LOKIR, "Damn you Stormcloaks. Skyrim was fine until you came along. Empire was nice and lazy. If they hadn't been looking for you, I could've stolen that horse and been half way to Hammerfell. You there. You and me - we shouldn't be here. It's these Stormcloaks the Empire wants.");
        Sleep(6);

        PrintDialogue(NPC_RALOF, "We're all brothers and sisters in binds now, thief.");
        Sleep(3);

        PrintDialogue(NPC_IMPERIAL_SOLDIER, "Shut up back there!");
        Sleep(2);

        PrintDialogueContext("Lokir looks at the gagged man.");
        Sleep(3);

        PrintDialogue(NPC_LOKIR, "And what’s wrong with him?");
        Sleep(3);

        PrintDialogue(NPC_RALOF, "Watch your tongue! You’re speaking to Ulfric Stormcloak, the true High King.");
        Sleep(3);

        PrintDialogue(NPC_LOKIR, "Ulfric? The Jarl of Windhelm? You’re the leader of the rebellion. But if they captured you… Oh gods, where are they taking us?");
        Sleep(4);

        PrintDialogue(NPC_RALOF, "I dont know where we're going, but Sovngarde awaits.");
        Sleep(3);

        PrintDialogue(NPC_LOKIR, "No, this can’t be happening. This isn’t happening.");
        Sleep(2);

        PrintDialogue(NPC_RALOF, "Hey, what village are you from, horse thief?");
        Sleep(3);

        PrintDialogue(NPC_LOKIR, "Why do you care?");
        Sleep(2);

        PrintDialogue(NPC_RALOF, "A Nord’s last thoughts should be of home.");
        Sleep(4);

        PrintDialogue(NPC_LOKIR, "Rorikstead. I’m… I’m from Rorikstead.");
        Sleep(2);

        PrintDialogueContext("You approach the village of Helgen. A soldier calls out to the lead wagon.");
        Sleep(3);

        PrintDialogue(NPC_IMPERIAL_SOLDIER, "General Tullius, sir! The headsman is waiting!");
        Sleep(4);

        PrintDialogue(NPC_GENERAL_TULLIUS, "Good. Let’s get this over with.");
        Sleep(5);

        PrintDialogue(NPC_LOKIR, "Shor, Mara, Dibella, Kynareth, Akatosh. Divines, please help me.");
        Sleep(4);

        PrintDialogue(NPC_RALOF, "Look at him, General Tullius the Military Governor. And it looks like the Thalmor are with him. Damn elves. I bet they had something to do with this. This is Helgen. I used to be sweet on a girl from here. Wonder if Vilod is still making that mead with juniper berries mixed in. Funny… when I was a boy, Imperial walls and towers used to make me feel so safe.");
        Sleep(5);

        PrintDialogueContext("A man and son watch the prisoners pull into town.");
        Sleep(3);

        PrintDialogue(NPC_HAMING, "Who are they, daddy? Where are they going?");
        Sleep(3);

        PrintDialogue(NPC_TOROLF, "You need to go inside, little cub.");
        Sleep(2);

        PrintDialogue(NPC_HAMING, "Why? I want to watch the soldiers.");
        Sleep(1);

        PrintDialogue(NPC_TOROLF, "Inside the house. Now.");
        Sleep(2);

        PrintDialogue(NPC_HAMING, "Yes, papa.");
        Sleep(2);

        PrintDialogue(NPC_IMPERIAL_CAPTAIN, "Get these prisoners out of the carts. Move it!");
        Sleep(2);

        PrintDialogue(NPC_LOKIR, "Why are we stopping?");
        Sleep(3);

        PrintDialogue(NPC_RALOF, "Why do you think? End of the line. Let's go. Shouldn't keep the gods waiting for us.");
        Sleep(4);

        PrintDialogue(NPC_LOKIR, "No! Wait! We're not rebels!");
        Sleep(3);

        PrintDialogue(NPC_RALOF, "Face your death with some courage, thief.");
        Sleep(2);

        PrintDialogue(NPC_LOKIR, "You've got to tell them! We weren't with you! This is a mistake!");
        Sleep(2);

        PrintDialogue(NPC_IMPERIAL_CAPTAIN, "Step towards the block when we call your name. One at a time.");
        Sleep(4);

        PrintDialogue(NPC_RALOF, "Empire loves their damn lists.");
        Sleep(4);

        PrintDialogue(NPC_HADVAR, "Ulfric Stormcloak. Jarl of Windhelm.");
        Sleep(3);

        PrintDialogue(NPC_RALOF, "It has been an honor, Jarl Ulfric!");
        Sleep(4);

        PrintDialogue(NPC_HADVAR, "Ralof of Riverwood. Lokir of Rorikstead.");
        Sleep(2);

        PrintDialogue(NPC_LOKIR, "No, I'm not a rebel. You can't do this!");
        Sleep(2);

        PrintDialogueContext("Lokir attempts to run away.");
        Sleep(2);

        PrintDialogue(NPC_IMPERIAL_CAPTAIN, "Halt!");
        Sleep(2);

        PrintDialogue(NPC_LOKIR, "You're not going to kill me!");
        Sleep(2);

        PrintDialogue(NPC_IMPERIAL_CAPTAIN, "Archers!");
        Sleep(1);

        PrintDialogueContext("An arrow is shot into Lokir's back");
        Sleep(3);

        PrintDialogue(NPC_IMPERIAL_CAPTAIN, "Anyone else feel like running?");
        Sleep(4);

        PrintDialogue(NPC_HADVAR, "Wait. You there. Step forward. Who are you?");
        Sleep(2);
    }

    public static void PlayHelgenScript(Race race)
    {
        Clear();

        Console.ForegroundColor = CONTEXTCOLOUR;
        Console.Write("Hadvar fills in the ledger.\n\n");
        Console.ForegroundColor = BASECOLOUR;
        Sleep(3);

        string dialogue = race.Name switch
        {
            "High Elf" => "You're not with the Thalmor Embassy, are you High Elf? No, that can't be right... I'm sorry. We'll make sure your remains are returned to Summerset Isle.",
            "Argonian" => "Are you a relative of one of the Riften dock workers, Argonian? I'm sorry. We'll make sure your remains are returned to Black Marsh.",
            "Wood Elf" => "Not many Wood Elves would choose to come alone to Skyrim. I'm sorry. We'll make sure your remains are returned to Valenwood.",
            "Breton" => "You from Daggerfall, Breton? Fleeing from some court intrigue? I'm sorry. We'll make sure your remains are returned to High Rock.",
            "Dark Elf" => "Another refugee? Gods really have abandoned your people, Dark Elf. I'm sorry. We'll make sure your remains are returned to Morrowind.",
            "Imperial" => "You're a long way from the Imperial City. What're you doing in Skyrim? I'm sorry. We'll make sure your remains are returned to Cyrodiil.",
            "Khajiit" => "You with one of the trade caravans, Khajiit? Your kind always seems to find trouble. I'm sorry. We'll make sure your remains are returned to Elsweyr.",
            "Nord" => "You picked a bad time to come home to Skyrim, kinsman. I'm sorry. At least you'll die here, in your homeland.",
            "Orc" => "You from one of the strongholds, Orc? How did you end up here? I'm sorry. We'll make sure your remains are returned to Orsinium.",
            "Redguard" => "What're you doing here, Redguard? You a sellsword? A sailor from Stros M'kai? I'm sorry. We'll make sure your remains are returned to Hammerfell.",
            _ => "I'm sorry. We'll make sure your remains are taken care of.",
        };

        PrintDialogue("NPC_HADVAR", dialogue);
        Sleep(2);
    }

    public static void FirstLoadingScript() 
    {
        Clear();

        Console.ForegroundColor = Scripts.BASECOLOUR;
        Console.Write(Data.DRAGON_ASCII);

        Console.ForegroundColor = Scripts.CONTEXTCOLOUR;

        PrintDialogueContext("\n\nAnd the scrolls have foretold, of black wings in the cold,\n" +
                             "that when brothers wage war come unfurled! Alduin, Bane of\n" +
                             "Kings, ancient shadow unbound, with a hunger to swallow the\n" +
                             "world! - Song of the Dragonborn");
        Sleep(12);
    }

    static void PlayIntroMusic()
    {
        try
        {
            SoundPlayer player = new(@"C:\Users\adunderdale\source\repos\lang\bin\Debug\intro.wav");
            player.Play();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing intro music: {ex.Message}");
        }
    }

    static void PrintDialogue(string speaker, string dialogue)
    {
        Console.Write($"\n{speaker}: ");

        foreach (char c in dialogue)
        {
            Console.Write(c);
            Thread.Sleep(20);
        }

        Console.WriteLine();
    }

    static void PrintDialogueContext(string dialogue) 
    {
        Console.ForegroundColor = CONTEXTCOLOUR;
        Console.Write($"\n\n{dialogue}\n\n");
        Console.ForegroundColor = BASECOLOUR;
    }

    static void Sleep(int seconds) => Thread.Sleep(seconds * 1000);

    static void Clear() => Console.Clear();
}

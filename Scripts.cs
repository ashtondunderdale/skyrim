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
    const string NPC_PRIESTESS_OF_ARKAY = "Priestess of Arkay";
    const string NPC_STORMCLOAK_SOLDIER = "Stormclock Soldier";
    const string NPC_VILOD = "Vilod";
    const string NPC_INGRID = "Ingrid";

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

        PrintDialogue(NPC_HADVAR, dialogue);
        Sleep(2);

        PrintDialogue(NPC_HADVAR, "Captain. What should we do? He's not on the list.");
        Sleep(2);

        PrintDialogue(NPC_IMPERIAL_CAPTAIN, "Forget the list. He goes to the block.");
        Sleep(3);

        PrintDialogue(NPC_HADVAR, "By your orders, Captain.");
        Sleep(2);

        PrintDialogue(NPC_HADVAR, "Follow the Captain, prisoner.");
        Sleep(2);

        PrintDialogueContext("You follow the Imperial Captain towards the block.");
        Sleep(5);

        PrintDialogue(NPC_GENERAL_TULLIUS, "Ulfric Stormcloak. Some here in Helgen call you a hero. But a hero doesn't use a power like the Voice to murder his king and usurp his throne.");
        Sleep(4);

        PrintDialogue(NPC_GENERAL_TULLIUS, "You started this war, plunged Skyrim into chaos, and now the Empire is going to put you down, and restore the peace.");
        Sleep(5);

        PrintDialogueContext("You hear an eery sound rumbling in the distance.");
        Sleep(2);

        PrintDialogue(NPC_HADVAR, "What was that?");
        Sleep(2);

        PrintDialogue(NPC_GENERAL_TULLIUS, "It's nothing. Carry on.");
        Sleep(2);

        PrintDialogue(NPC_IMPERIAL_CAPTAIN, "Yes, General Tullius.");
        Sleep(1);

        PrintDialogue(NPC_IMPERIAL_CAPTAIN, "Give them their last rites");
        Sleep(3);

        PrintDialogue(NPC_PRIESTESS_OF_ARKAY, "As we commend your souls to Aetherius, blessings of the Eight Divines upon you, for you are the salt and earth of Nirn, our beloved...");
        Sleep(4);

        PrintDialogueContext("The priestess is cut off by a Stormcloak soldier");
        Sleep(1);

        PrintDialogue(NPC_STORMCLOAK_SOLDIER, "For the love of Talos, shut up and let's get this over with.");
        Sleep(2);

        PrintDialogue(NPC_PRIESTESS_OF_ARKAY, "As you wish.");
        Sleep(5);

        PrintDialogueContext("The soldier is taken to the chopping block.");
        Sleep(3);

        PrintDialogue(NPC_STORMCLOAK_SOLDIER, "Come on, I haven't got all morning.");
        Sleep(2);

        PrintDialogue(NPC_STORMCLOAK_SOLDIER, "My ancestors are smiling at me, Imperials. Can you say the same?");
        Sleep(4);

        PrintDialogueContext("The Soldiers head falls into the basket below.");
        Sleep(3);

        PrintDialogue(NPC_STORMCLOAK_SOLDIER, "You Imperial bastards!");
        Sleep(2);

        PrintDialogue(NPC_VILOD, "Justice!");
        Sleep(2);

        PrintDialogue(NPC_INGRID, "Death to the Stormcloaks!");
        Sleep(2);

        PrintDialogue(NPC_RALOF, "As fearless in death as he was in life.");
        Sleep(2);

        PrintDialogue(NPC_IMPERIAL_CAPTAIN, $"Next, the {race.Name}");
        Sleep(2);

        PrintDialogueContext("You hear the eerie sound rumbling in the distance once more.");
        Sleep(3);

        PrintDialogue(NPC_HADVAR, "There it is again. Did you hear that?");
        Sleep(3);

        PrintDialogue(NPC_IMPERIAL_CAPTAIN, "I said, next prisoner!");
        Sleep(2);

        PrintDialogue(NPC_HADVAR, "To the block, prisoner. Nice and easy.");
        Sleep(2);

        PrintDialogueContext("You walk over to the chopping block and lie down, facing the sky.");
        Sleep(4);

        PrintDialogue(NPC_GENERAL_TULLIUS, "What in Oblivion is that?");
        Sleep(2);

        PrintDialogueContext("A dragon emerges from the clouds.");
        Sleep(2);

        PrintDialogue(NPC_IMPERIAL_CAPTAIN, "Sentries! What do you see?");
        Sleep(2);

        PrintDialogue(NPC_IMPERIAL_SOLDIER, "It's in the clouds!");
        Sleep(2);

        PrintDialogue(NPC_STORMCLOAK_SOLDIER, "Dragon!");
        Sleep(2);

        PrintDialogueContext("The dragon unleashes its thunderous voice upon the world.");
        Sleep(2);

        PrintDialogue(NPC_RALOF, $"Hey {race.Name}. Get up! Come on, the gods won't give use another chance!");
        Sleep(3);

        PrintDialogueContext("You follow Ralof through Helgen, trying to find a safe path between the fire, falling rocks, and rubble. You eventually come to an opening and find Hadvar.");
        Sleep(4);

        PrintDialogue(NPC_HADVAR, $"Still alive prisoner? Keep close to me if you want to stay that way.");
        Sleep(2);

        PrintDialogueContext("You follow Hadvar towards the keep. Hidden next to a stone wall, the dragon lands above you and shouts what seemed like thunder through the air.");
        Sleep(3);

        PrintDialogueContext("You continue to follow Hadvar. Ralof appears and stands in his way");
        Sleep(2);

        PrintDialogue(NPC_HADVAR, "Ralof! You damned trator. Out of my way!");
        Sleep(3);

        PrintDialogue(NPC_RALOF, "We're escaping, Hadvar. You're not stopping us this time.");
        Sleep(2);

        PrintDialogue(NPC_HADVAR, "Fine. I hope that dragon takes you all to Sovngarde.");
        Sleep(2);

        PrintDialogue(NPC_RALOF, "You! Come on, into the keep!");
        Sleep(1);

        PrintDialogue(NPC_HADVAR, "With me, prisoner. Let's go!");
        Sleep(3);

        ShowPlayerDecisionOptions(new List<string>() { "Hadvar", "Ralof" }, "Enter the keep with Hadvar or Ralof.");
    }

    public static string ShowPlayerDecisionOptions(List<string> options, string decisionHeader)
    {
        Clear();

        Console.ForegroundColor = ConsoleColor.DarkGray;
        int activeOptionIndex = 0;
        string activeOption = options[activeOptionIndex];

        while (true)
        {
            Console.WriteLine($"{decisionHeader}\n");

            for (int i = 0; i < options.Count; i++)
            {
                if (options[i] == activeOption)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\n > {options[i]} \n");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else Console.WriteLine($"{options[i]}");
            }

            ConsoleKeyInfo input = Console.ReadKey(intercept: true);

            if (input.Key == ConsoleKey.UpArrow)
            {
                if (activeOptionIndex - 1 > -1)
                {
                    activeOptionIndex--;
                    activeOption = options[activeOptionIndex];
                }
            }
            else if (input.Key == ConsoleKey.DownArrow)
            {
                if (activeOptionIndex < options.Count - 1)
                {
                    activeOptionIndex++;
                    activeOption = options[activeOptionIndex];
                }
            }
            else if (input.Key == ConsoleKey.Enter) return options[activeOptionIndex];

            Console.Clear();
        }
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

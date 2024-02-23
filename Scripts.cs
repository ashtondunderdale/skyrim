using System.Media;
using static System.Net.Mime.MediaTypeNames;

namespace skyrim;

internal class Scripts
{
    public static void PlayIntroScript()
    {
        Clear();

        Sleep(2);
        PlayIntroMusic();

        Sleep(0); // 17

        Console.ForegroundColor = ConsoleColor.Gray;
        PrintDialogueContext("\tThe Elder Scrolls");
        Sleep(12);
        Clear();

        Console.ForegroundColor = ConsoleColor.White;
        PrintDialogueContext("\tSkyrim");
        Sleep(7);
        Clear();

        Sleep(5);

        PrintDialogueContext("You awake on an Imperial wagon driving four prisoners down a snowy mountain pass.");
        Sleep(7);

        PrintDialogue("Ralof", "Hey, you. You're finally awake. You were trying to cross the border, right? Walked right into that Imperial ambush, same as us, and that thief over there.");
        Sleep(5);

        PrintDialogue("Lokir", "Damn you Stormcloaks. Skyrim was fine until you came along. Empire was nice and lazy. If they hadn't been looking for you, I could've stolen that horse and been half way to Hammerfell. You there. You and me - we shouldn't be here. It's these Stormcloaks the Empire wants.");
        Sleep(9);

        PrintDialogue("Ralof", "We're all brothers and sisters in binds now, thief.");
        Sleep(3);

        PrintDialogue("Imperial Soldier", "Shut up back there!");
        Sleep(2);

        Console.ForegroundColor = ConsoleColor.Gray;
        PrintDialogueContext("Lokir looks at the gagged man.");
        Console.ForegroundColor = ConsoleColor.White;
        Sleep(3);

        PrintDialogue("Lokir", "And what’s wrong with him?");
        Sleep(3);

        PrintDialogue("Ralof", "Watch your tongue! You’re speaking to Ulfric Stormcloak, the true High King.");
        Sleep(4);

        PrintDialogue("Lokir", "Ulfric? The Jarl of Windhelm? You’re the leader of the rebellion. But if they captured you… Oh gods, where are they taking us?");
        Sleep(5);

        PrintDialogue("Ralof", "I dont know where we're going, but Sovngarde awaits.");
        Sleep(5);

        PrintDialogue("Lokir", "No, this can’t be happening. This isn’t happening.");
        Sleep(5);

        PrintDialogue("Ralof", "Hey, what village are you from, horse thief?");
        Sleep(3);

        PrintDialogue("Lokir", "Why do you care?");
        Sleep(3);

        PrintDialogue("Ralof", "A Nord’s last thoughts should be of home.");
        Sleep(4);

        PrintDialogue("Lokir", "Rorikstead.I’m… I’m from Rorikstead.");
        Sleep(2);

        Console.ForegroundColor = ConsoleColor.Gray;
        PrintDialogueContext("You approach the village of Helgen. A soldier calls out to the lead wagon.");
        Console.ForegroundColor = ConsoleColor.White;
        Sleep(3);

        PrintDialogue("Imperial Soldier", "General Tullius, sir! The headsman is waiting!");
        Sleep(4);

        PrintDialogue("General Tullius", "Good. Let’s get this over with.");
        Sleep(5);

        PrintDialogue("Lokir", "Lokir: Shor, Mara, Dibella, Kynareth, Akatosh. Divines, please help me.");
        Sleep(5);

        PrintDialogue("Ralof", "Ralof: Look at him, General Tullius the Military Governor. And it looks like the Thalmor are with him. Damn elves. I bet they had something to do with this. This is Helgen. I used to be sweet on a girl from here. Wonder if Vilod is still making that mead with juniper berries mixed in. Funny… when I was a boy, Imperial walls and towers used to make me feel so safe.");
        Sleep(7);

        Console.ForegroundColor = ConsoleColor.Gray;
        PrintDialogueContext("A man and son watch the prisoners pull into town.");
        Console.ForegroundColor = ConsoleColor.White;
        Sleep(3);

        PrintDialogue("Haming", "Who are they, daddy? Where are they going?");
        Sleep(3);

        PrintDialogue("Torolf", "You need to go inside, little cub.");
        Sleep(2);

        PrintDialogue("Haming", "Why? I want to watch the soldiers.");
        Sleep(1);

        PrintDialogue("Torolf", "Inside the house. Now.");
        Sleep(2);

        PrintDialogue("Haming", "Yes, papa.");
        Sleep(2);

        PrintDialogue("Imperial Captain", "Get these prisoners out of the carts. Move it!");
        Sleep(2);

        PrintDialogue("Lokir", "Lokir: Why are we stopping?");
        Sleep(2);

        PrintDialogue("Ralof", "Ralof: Why do you think? End of the line. Let's go. Shouldn't keep the gods waiting for us.");
        Sleep(2);

        PrintDialogue("Lokir", "Lokir: No! Wait! We're not rebels!");
        Sleep(2);

        PrintDialogue("Ralof", "Ralof: Face your death with some courage, thief.");
        Sleep(2);

        PrintDialogue("Lokir", "Lokir: You've got to tell them! We weren't with you! This is a mistake!");
        Sleep(2);

        PrintDialogue("Imperial Captain", "Step towards the block when we call your name. One at a time.");
        Sleep(2);

        PrintDialogue("Ralof", "Ralof: Empire loves their damn lists.");
        Sleep(2);

        PrintDialogue("Hadvar", "Ulfric Stormcloak. Jarl of Windhelm.");
        Sleep(2);

        PrintDialogue("Ralof", "It has been an honor, Jarl Ulfric!");
        Sleep(2);

        PrintDialogue("Hadvar", "Ralof of Riverwood. Lokir of Rorikstead.");
        Sleep(2);

        PrintDialogue("Lokir", "Lokir: No, I'm not a rebel. You can't do this!");
        Sleep(2);

        Console.ForegroundColor = ConsoleColor.Gray;
        PrintDialogueContext("Lokir attempts to run away.");
        Console.ForegroundColor = ConsoleColor.White;
        Sleep(3);

        PrintDialogue("Imperial Captain", "Halt");
        Sleep(2);

        PrintDialogue("Lokir", "You're not going to kill me!");
        Sleep(2);

        PrintDialogue("Imperial Captain", "Archers!");
        Sleep(2);

        PrintDialogue("Imperial Captain", "Anyone else feel like running?");
        Sleep(2);

        PrintDialogue("Hadvar", "Wait. You there. Step forward. Who are you?");
        Sleep(2);
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

    static void PrintDialogueContext(string dialogue) => Console.Write($"\n\n{dialogue}\n\n");

    static void Sleep(int seconds) => Thread.Sleep(seconds * 1000);

    static void Clear() => Console.Clear();
}

using skyrim;
using System.Media;

namespace Skyrim;

internal class Program
{
    static void Main()
    {
        SoundPlayer player = new(@"C:\Users\adunderdale\source\repos\lang\bin\Debug\menu.wav");
        PlayMenuMusic(player);

        while (true) 
        {
            Console.ForegroundColor = Scripts.BASECOLOUR;
            Console.Write(Data.SKYRIM_LOGO);

            Console.ForegroundColor = Scripts.CONTEXTCOLOUR;
            Console.WriteLine("\n\n1. New\n2. Load\n");

            string? menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    player.Stop();
                    PlayNewGame();
                    break;

                case "2":
                    player.Stop();
                    // to implement continue game
                    break;

                default:
                    Console.Clear();
                    continue;
            }
        }
    }

    public static void PlayNewGame() 
    {
        Console.WriteLine("\nPlay Intro? (y)");
        string? playIntro = Console.ReadLine();

        if (playIntro == "y")
        {
            Scripts.PlayIntroScript();
        }

        Console.Clear();
        Race race = ShowCharacterCreationMenu();

        while (true) 
        {
            Console.WriteLine("\nEnter name: ");
            string? name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name))
            {
                Player player = new(name, race);
                break;
            }
        }

        // here
    }

    public static Race ShowCharacterCreationMenu() 
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        int activeRaceIndex = 0;
        Race activeRace = Race.Races[activeRaceIndex];

        while (true)
        {
            for (int i = 0; i < Race.Races.Count; i++)
            {
                if (Race.Races[i] == activeRace)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\n > {Race.Races[i].Name} \n");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else
                {
                    Console.WriteLine($"{Race.Races[i].Name}");
                }
            }

            Console.SetCursorPosition(20, 20);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(Race.Races[activeRaceIndex].Description);
            Console.ForegroundColor = ConsoleColor.DarkGray;

            ConsoleKeyInfo input = Console.ReadKey(intercept: true);

            if (input.Key == ConsoleKey.UpArrow)
            {
                if (activeRaceIndex - 1 > -1)
                {
                    activeRaceIndex--;
                    activeRace = Race.Races[activeRaceIndex];
                }
            }
            else if (input.Key == ConsoleKey.DownArrow)
            {
                if (activeRaceIndex < Race.Races.Count - 1)
                {
                    activeRaceIndex++;
                    activeRace = Race.Races[activeRaceIndex];
                }
            }
            else if (input.Key == ConsoleKey.Enter) return Race.Races[activeRaceIndex];     

            Console.Clear();
        }
    }

    static void PlayMenuMusic(SoundPlayer player)
    {
        try
        {
            player.Play();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error playing intro music: {ex.Message}");
        }
    }
}

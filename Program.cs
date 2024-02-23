using skyrim;
using System.Media;

namespace Skyrim;

internal class Program
{
    static void Main()
    {

        Play();
    }

    public static void Play() 
    {
        Console.WriteLine("Play Intro? (y)");
        string? playIntro = Console.ReadLine();

        if (playIntro == "y")
        {
            Scripts.PlayIntroScript();
        }

        Console.Clear();
        Race race = ShowCharacterCreationMenu();
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
}

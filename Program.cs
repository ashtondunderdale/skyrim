using skyrim;
using System.Media;

namespace Skyrim;

internal class Program
{
    static void Main()
    {
        ShowCharacterCreation();

        Console.WriteLine("Play Intro? (y)");
        string? playIntro = Console.ReadLine();

        if (playIntro == "y")
        {
            Scripts.PlayIntroScript();
        }

    }

    public static Race ShowCharacterCreation() 
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        int activeRaceIndex = 0;
        Race activeRace = Race.Races[activeRaceIndex];

        while (true)
        {
            foreach (var race in Race.Races)
            {
                if (race == activeRace)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(race.Name);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else
                {
                    Console.WriteLine(race.Name);
                }
            }

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
            else if (input.Key == ConsoleKey.Enter) 
            {
                return Race.Races[activeRaceIndex];
            }

            Console.Clear();
        }
    }
}

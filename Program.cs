using skyrim;
using System.Media;

namespace Skyrim;

internal class Program
{
    static void Main()
    {
        Race race = ShowCharacterCreation();
        Console.Write(race.Name);

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
            Console.WriteLine(Race.Races[activeRaceIndex].Description);

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

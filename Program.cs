using skyrim;
using System.Media;

namespace Skyrim;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Play Intro? (y)");
        string? playIntro = Console.ReadLine();

        if (playIntro == "y")
        {
            Scripts.PlayIntroScript();
        }
    }
}

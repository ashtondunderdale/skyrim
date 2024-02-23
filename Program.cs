namespace skyrim;

internal class Program
{
    static void Main()
    {

        Console.WriteLine("Play Intro? (y)");
        string? playIntro = Console.ReadLine();

        if (playIntro == "y") 
        {
            PlayIntroScript();
        }
    }

    static void PlayIntroScript() 
    {
        Console.Clear();
        Console.WriteLine("\n\n\tThe Elder Scrolls");
        Thread.Sleep(3000);
        Console.Clear();
        Console.WriteLine("\n\n\tSkyrim");
        Thread.Sleep(3000);
        Console.Clear();


        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You awake on an Imperial wagon driving four prisoners down a snowy mountain pass.");
        Thread.Sleep(1000);
    }
}

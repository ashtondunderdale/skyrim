namespace Skyrim;

internal class GameContext
{
    public Player Player { get; set; }
    public static Scene? Scene { get; set; }

    public GameContext(Player player) 
    {
        Player = player;
    }

    public void LoadScene(Scene scene, Action script) 
    {
        Scene = scene;
        script();
    }

    public void HelgenKeep() 
    {
        // Scripts.PlayHelgenScript(Player.Race);

        string helgenKeepChoice = Scripts.ShowPlayerDecisionOptions(new List<string>() { "Hadvar", "Ralof" }, "Enter the keep with Hadvar or Ralof.");

        if (helgenKeepChoice == "Hadvar")
        {
            Scripts.PlayHelgenKeepHadvarScript();
        }
        else 
        {
            Scripts.PlayHelgenKeepRalofScript();
        }

        PromptEnter();

        while (true) 
        {
            Console.Clear();

            PrintSceneObjects("You decide to look around the Imperial barracks.");
        }
    }

    public static void PrintSceneObjects(string sceneHeader) 
    {
        List<string> sceneObjects = new();

        Console.WriteLine($"{sceneHeader}\n");

        foreach (var sceneObject in Scene.Objects)
        {
            if (sceneObject is ItemContainer container)
            {
                Console.WriteLine($"{container.Name} ({container.GameItems.Count})");
                sceneObjects.Add(container.Name!);
            }
            else
            {
                Console.WriteLine(sceneObject.Name);
                sceneObjects.Add(sceneObject.Name!);
            }
        }

        Scripts.ShowPlayerDecisionOptions(sceneObjects, "");

        Console.ReadLine();
    }

    public static void PromptEnter() 
    {
        Console.ForegroundColor = Scripts.CONTEXTCOLOUR;
        Console.WriteLine("\n\n\tPress Enter.");
        Console.ForegroundColor = Scripts.BASECOLOUR;

        Console.ReadKey();
        Console.Clear();
    }
}

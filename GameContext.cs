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
        List<dynamic> sceneObjects = new();

        Console.WriteLine($"{sceneHeader}\n");

        foreach (var sceneObject in Scene.Objects)
        {
            if (sceneObject is ItemContainer container)
            {
                Console.WriteLine($"{container.Name} ({container.GameItems.Count})");
                sceneObjects.Add(container);
            }
            else
            {
                Console.WriteLine(sceneObject.Name);
                sceneObjects.Add(sceneObject);
            }
        }

        dynamic selectedObject = ListItemsInScene(sceneObjects);
        Console.Write(selectedObject);

        Console.ReadLine();
    }

    public static dynamic ListItemsInScene(List<dynamic> sceneObjects)
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkGray;
        int activeOptionIndex = 0;
        dynamic activeOption = sceneObjects[activeOptionIndex];

        while (true)
        {
            for (int i = 0; i < sceneObjects.Count; i++)
            {
                if (ReferenceEquals(sceneObjects[i], activeOption))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine($"\n > {sceneObjects[i].Name} \n");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else Console.WriteLine($"{sceneObjects[i].Name}");
            }

            ConsoleKeyInfo input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.UpArrow)
            {
                if (activeOptionIndex - 1 > -1)
                {
                    activeOptionIndex--;
                    activeOption = sceneObjects[activeOptionIndex];
                }
            }
            else if (input.Key == ConsoleKey.DownArrow)
            {
                if (activeOptionIndex < sceneObjects.Count - 1)
                {
                    activeOptionIndex++;
                    activeOption = sceneObjects[activeOptionIndex];
                }
            }
            else if (input.Key == ConsoleKey.Enter) return sceneObjects[activeOptionIndex];

            Console.Clear();
        }
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

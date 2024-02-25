namespace Skyrim;

internal class GameContext
{
    public static Player Player { get; set; }
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
            //Scripts.PlayHelgenKeepHadvarScript();
        }
        else 
        {
            Scripts.PlayHelgenKeepRalofScript();
        }

        PromptEnter();

        while (true) 
        {
            Console.Clear();

            GetSceneObjects("You decide to look around the Imperial barracks.");
        }
    }

    private static List<dynamic>? initializedSceneObjects; // Declare a static field to store initialized scene objects

    public static void GetSceneObjects(string sceneHeader)
    {
        List<dynamic> sceneObjects;

        if (initializedSceneObjects == null)
        {
            // If the scene objects haven't been initialized yet, fetch them from Scene.Objects
            sceneObjects = new List<dynamic>();
            foreach (var sceneObject in Scene.Objects)
            {
                if (sceneObject is ItemContainer container)
                {
                    sceneObjects.Add(container);
                }
                else
                {
                    sceneObjects.Add(sceneObject);
                }
            }
            initializedSceneObjects = sceneObjects; // Store the initialized scene objects
        }
        else
        {
            // If the scene objects have already been initialized, use the stored sceneObjects
            sceneObjects = initializedSceneObjects;
        }

        dynamic selectedObject = ListItemsInScene(sceneObjects, sceneHeader);
        sceneObjects.Remove(selectedObject);

        AddToInventory(selectedObject);
    }


    public static void AddToInventory(dynamic selectedObject) 
    {
        Player.Inventory.Add(selectedObject);
        Console.Write($"Added: {selectedObject.Name}");
        Console.ReadKey();
    }

    public static dynamic ListItemsInScene(List<dynamic> sceneObjects, string sceneHeader)
    {
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkGray;
        int activeOptionIndex = 0;
        dynamic activeOption = sceneObjects[activeOptionIndex];

        while (true)
        {
            Console.WriteLine($"{sceneHeader}\n");

            for (int i = 0; i < sceneObjects.Count; i++)
            {
                if (ReferenceEquals(sceneObjects[i], activeOption))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write($"\n > {sceneObjects[i].Name}");

                    if (sceneObjects[i] is ItemContainer container && container.GameItems != null)
                    {
                        Console.WriteLine($" ({container.GameItems.Count})\n");
                    }
                    else
                    {
                        Console.WriteLine("\n");
                    }

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else
                {
                    Console.Write($"{sceneObjects[i].Name}");

                    if (sceneObjects[i] is ItemContainer container && container.GameItems != null)
                    {
                        Console.WriteLine($" ({container.GameItems.Count})");
                    }
                    else 
                    { 
                        Console.Write("\n");
                    }
                }
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
            else if (input.Key == ConsoleKey.Enter)
            {
                if (sceneObjects[activeOptionIndex] is ItemContainer container)
                {
                    dynamic selectedFromContainer = ListItemsInScene(container.GameItems.Select(x => (dynamic)x).ToList(), sceneHeader);
                    container.GameItems.Remove(selectedFromContainer);

                    if (selectedFromContainer != null)
                    {
                        return selectedFromContainer;
                    }
                    else
                    {
                        return container;
                    }
                }

                return sceneObjects[activeOptionIndex];
            }


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

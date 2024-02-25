namespace Skyrim;

internal class GameContext
{
    public static Player Player { get; set; }
    public static Scene? Scene { get; set; }

    private static List<dynamic>? InitialisedSceneObjects;

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

    public static void GetSceneObjects(string sceneHeader)
    {
        List<dynamic> sceneObjects;

        if (InitialisedSceneObjects == null && Scene!.Objects is not null)
        {
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
            InitialisedSceneObjects = sceneObjects;
        }
        else
        {
            sceneObjects = InitialisedSceneObjects!;
        }

        dynamic selectedObject = ListItemsInScene(sceneObjects, sceneHeader);
        sceneObjects.Remove(selectedObject);

        AddToInventory(selectedObject);
    }


    public static void AddToInventory(dynamic selectedObject)
    {
        if (selectedObject is not null)
        {
            Player.Inventory.Add(selectedObject);
            Console.Write($"\nAdded: {selectedObject.Name}");
            Console.ReadKey();
        }
    }

    public static dynamic ListItemsInScene(List<dynamic> sceneObjects, string sceneHeader)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGray;

        int activeOptionIndex = 0;
        dynamic activeOption = sceneObjects.Count > 0 ? sceneObjects[activeOptionIndex] : null;

        DisplaySceneObjects(sceneObjects, sceneHeader, activeOption);

        return ProcessUserItemAction(sceneObjects, activeOptionIndex, sceneHeader);
    }


    private static void DisplaySceneObjects(List<dynamic> sceneObjects, string sceneHeader, dynamic activeOption)
    {
        Console.WriteLine($"{sceneHeader}\n");

        foreach (var sceneObject in sceneObjects)
        {
            if (ReferenceEquals(sceneObject, activeOption))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"\n > {sceneObject.Name}");

                if (sceneObject is ItemContainer container && container.GameItems != null && container.GameItems.Count > 0)
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
                Console.Write($"{sceneObject.Name}");

                if (sceneObject is ItemContainer container && container.GameItems != null && container.GameItems.Count > 0)
                {
                    Console.WriteLine($" ({container.GameItems.Count})");
                }
                else
                {
                    Console.Write("\n");
                }
            }
        }
    }

    private static dynamic ProcessUserItemAction(List<dynamic> sceneObjects, int activeOptionIndex, string sceneHeader)
    {
        while (true)
        {
            ConsoleKeyInfo input = Console.ReadKey(true);

            if (input.Key == ConsoleKey.UpArrow)
            {
                if (activeOptionIndex - 1 > -1)
                {
                    activeOptionIndex--;
                }
            }
            else if (input.Key == ConsoleKey.DownArrow)
            {
                if (activeOptionIndex < sceneObjects.Count - 1)
                {
                    activeOptionIndex++;
                }
            }
            else if (input.Key == ConsoleKey.Enter)
            {
                if (sceneObjects[activeOptionIndex] is ItemContainer container)
                {
                    if (container.GameItems != null && container.GameItems.Count > 0)
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
                    else
                    {
                        return null;
                    }
                }
                return sceneObjects[activeOptionIndex];
            }
            else if (input.Key == ConsoleKey.Tab)
            {
                DisplayInventory();
            }

            Console.Clear();
            dynamic activeOption = sceneObjects.Count > 0 ? sceneObjects[activeOptionIndex] : null;

            DisplaySceneObjects(sceneObjects, sceneHeader, activeOption);
        }
    }

    public static void DisplayInventory()
    {
        Console.Clear();

        Console.WriteLine($"{Player.Name} | Level {Player.Level}");

        Dictionary<string, int> itemCounts = new();

        foreach (GameItem item in Player.Inventory)
        {
            if (itemCounts.ContainsKey(item.Name!))
            {
                itemCounts[item.Name!]++;
            }
            else
            {
                itemCounts[item.Name!] = 1;
            }
        }

        foreach (var pair in itemCounts)
        {
            string itemName = pair.Key;
            int itemCount = pair.Value;

            Console.WriteLine($"{itemName} ({itemCount})");
        }

        Console.ReadKey();
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

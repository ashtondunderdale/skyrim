namespace Skyrim;

internal class GameContext
{
    public Player Player { get; set; }
    public Scene? Scene { get; set; }

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

        
    }
}

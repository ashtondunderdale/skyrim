namespace Skyrim;

internal class GameContext
{
    Player Player { get; set; }
    Scene? Scene { get; set; }

    public GameContext(Player player) 
    {
        Player = player;
    }

    public void HelgenKeep() 
    {
        Scene = Scene.HelgenKeep;

        Scripts.PlayHelgenScript(Player.Race);

        string helgenKeepChoice = Scripts.ShowPlayerDecisionOptions(new List<string>() { "Hadvar", "Ralof" }, "Enter the keep with Hadvar or Ralof.");

        if (helgenKeepChoice == "Hadvar")
        {
            Scripts.PlayHelgenKeepHadvarScript();
        }
    }
}

namespace Skyrim;

internal class Scene
{
    public List<GameItem> Objects { get; set; }

    public static Scene HelgenKeep { get; } = new Scene { Objects = { 

            new ItemContainer(new List<GameItem> 
            {  
                Weapon.IronSword
            }
    )}};
}

namespace Skyrim;

internal class Scene
{
    public List<GameItem> Objects { get; set; }
    public static Scene HelgenKeep { get; }

    static Scene()
    {
        HelgenKeep = new Scene
        {
            Objects = new List<GameItem>
            {
                new ItemContainer(new List<GameItem>
                {
                    Weapon.IronSword
                })
            }
        };
    }
}

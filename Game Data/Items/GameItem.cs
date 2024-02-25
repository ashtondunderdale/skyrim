namespace Skyrim;

internal class GameItem
{
    public string ID = Guid.NewGuid().ToString();

    public string? Name { get; set; }

    public int Weight { get; set; }

    public int Value { get; set; }
}

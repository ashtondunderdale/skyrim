namespace math_lang;

internal class Lexer
{
    public static void Parse() 
    {
        string path = @"C:\Users\adunderdale\text.txt";
        var content = File.ReadAllLines(path);

        ReadToken(content);
    }

    public static void ReadToken(string[] content) 
    {
        foreach (var line in content)
        {
            string[] tokens = line.Split('\n');

            foreach (var token in tokens) 
            { 
                
            }
        }
    }
}

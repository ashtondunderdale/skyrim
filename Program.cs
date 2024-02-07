using System.Text;

namespace math_lang;

internal class Program
{
    static void Main()
    {
        try
        {
            Lexer.ReadFile();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }
    }
}
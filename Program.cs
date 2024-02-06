using System.Text;

namespace math_lang;

internal class Program
{
    static void Main()
    {
        try
        {
            MathLang();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading the file: {ex.Message}");
        }
    }

    static void MathLang()
    {
        const Int32 BufferSize = 128;
        using var fileStream = File.OpenRead("C:\\Users\\adunderdale\\mathlang.txt");
        using var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize);
        String line;
        while ((line = streamReader.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }
    }
}
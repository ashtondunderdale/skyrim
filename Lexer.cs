using System.Text.RegularExpressions;

namespace math_lang;

internal class Lexer
{
    static List<Token> tokens = new();
    const string SEPARATOR = ":";

    static readonly Dictionary<string, TokenType> keywords = new()
    {
        {"var", TokenType.var},
        {"print", TokenType.print}
    };

    public enum TokenType
    {
        var,
        print,
    }

    public static void ReadFile()
    {
        string content = File.ReadAllText(@"C:\Users\adunderdale\text.txt");
        Parse(content);
    }

    public static void Parse(string content)
    {

        string[] lines = content.Split('\n');

        foreach (var line in lines)
        {
            string[] words = line.Split(' ');

            foreach (var word in words)
            {
                if (word.Contains(SEPARATOR)) 
                {
                    var parts = word.Split(SEPARATOR);

                    if (IsKeywordMatch(parts[0])) 
                    {
                        try
                        {
                            tokens.Add(new Token(parts[0], keywords[parts[0]]));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                        }
                    }
                }

                else if (IsKeywordMatch(word))
                {
                    try
                    {
                        tokens.Add(new Token("", keywords[word]));
                    }
                    catch (Exception e) 
                    {
                        Console.WriteLine(e);
                    }
                }
            }
        }
        OutputTokens();
    }

    static bool IsKeywordMatch(string word)
    {
        foreach (var keyword in keywords.Keys)
        {
            if (Regex.IsMatch(word, @"\b" + Regex.Escape(keyword) + @"\b")) return true;     
        }
        return false;
    }

    static void OutputTokens() 
    {
        foreach (Token token in tokens) 
        {
            Console.WriteLine(token.Value);
        }
    }
}

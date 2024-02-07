using System.Text.RegularExpressions;

namespace math_lang;

internal class Lexer
{
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
        List<Token> tokens = new();

        string[] lines = content.Split('\n');

        foreach (var line in lines)
        {
            string[] words = line.Split(' ');

            foreach (var word in words)
            {
                if (IsKeywordMatch(word))
                {
                    tokens.Add(new Token("", keywords[word]));
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


}

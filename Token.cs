using static math_lang.Lexer;

namespace math_lang
{
    internal class Token
    {
        public string Value;
        public TokenType Type;

        public Token(string value, TokenType type) 
        {
            Value = value;
            Type = type;
        }
    }
}

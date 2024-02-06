namespace math_lang;

internal class Register
{
    public static string Variable;
    public static dynamic Value;

    public Register(string variable, dynamic value) 
    {
        Variable = variable;
        Value = value;
    }
}

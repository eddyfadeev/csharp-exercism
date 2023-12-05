using System;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {
        if (string.IsNullOrWhiteSpace(statement))
            return "Fine. Be that way!";
        
        if ((statement.Any(char.IsLetter) && statement.ToUpperInvariant() == statement) && statement.EndsWith('?'))
            return "Calm down, I know what I'm doing!";
        
        if (statement.Any(char.IsLetter) && statement.ToUpperInvariant() == statement)
            return "Whoa, chill out!";
        
        return statement.TrimEnd().EndsWith('?') ? "Sure." : "Whatever.";
    }
}
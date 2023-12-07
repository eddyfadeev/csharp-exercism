using System;
using System.Text;

public static class Identifier
{
    private static bool IsGreekLowerCase(char c) => c is >= 'α' and <= 'ω';
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < identifier.Length; i++)
        {
            if (char.IsWhiteSpace(identifier[i]))
            {
                sb.Append('_');
            }
            else if (char.IsControl(identifier[i]))
            {
                sb.Append("CTRL");
            }
            else if (identifier[i].Equals('-'))
            {
                sb.Append(identifier[i + 1].ToString().ToUpper());
                i++;
            }
            else if (!char.IsLetter(identifier[i]) || IsGreekLowerCase(identifier[i]))
            {
                continue;
            }
            else
            {
                sb.Append(identifier[i]);
            }
            
        }

        return sb.ToString();
    }
}

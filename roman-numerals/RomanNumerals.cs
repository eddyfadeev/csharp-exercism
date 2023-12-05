using System;
using System.Text; // Include System.Text for StringBuilder

public static class RomanNumeralExtension
{
    // Array of tuples combining the integers with their Roman numeral strings
    private static readonly (int Value, string Numeral)[] RomanNumerals =
    {
        (1000, "M"), (900, "CM"), (500, "D"), (400, "CD"),
        (100, "C"), (90, "XC"), (50, "L"), (40, "XL"),
        (10, "X"), (9, "IX"), (5, "V"), (4, "IV"), (1, "I")
    };

    public static string ToRoman(this int value)
    {
        if (value <= 0 || value > 3999)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Value must be between 1 and 3999.");
        }

        var result = new StringBuilder(); // StringBuilder instead of string for efficiency.

        foreach (var (val, numeral) in RomanNumerals) // Foreach loop to iterate over the array
        {
            while (value >= val)
            {
                result.Append(numeral); 
                value -= val;
            }
        }

        return result.ToString(); // Convert the StringBuilder to a string
    }
}
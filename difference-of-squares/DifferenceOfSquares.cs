using System;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int result = 0;

        for (int i = 0; i <= max; i++)
        {
            result += i;
        }

        return (int) Math.Pow(result, 2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        int result = 0;

        for (int i = 0; i <= max; i++)
        {
            result += (int)Math.Pow(i, 2);
        }

        return result;
    }

    public static int CalculateDifferenceOfSquares(int max) => CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
}
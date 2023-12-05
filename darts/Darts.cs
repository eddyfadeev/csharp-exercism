using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double distanceFromTheCenter = Math.Sqrt(x * x + y * y);

        return distanceFromTheCenter switch
        {
            > 10.0d => 0,
            > 5.0d => 1,
            > 1.0d => 5,
            _ => 10
        };
    }
}

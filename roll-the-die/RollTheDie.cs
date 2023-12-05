using System;

public class Player
{
    private readonly Random _randomizer = new();
    public int RollDie() => _randomizer.Next(1, 18);

    public double GenerateSpellStrength() => _randomizer.NextDouble() * 100.0d;
}

using System.Management.Automation;

namespace RpgCombat.Core;

public static class Dice
{
    private static readonly Random _randomizer = new Random();
    /// <summary>
    /// Static method returns random integer from range minValue, maxValue. Unlike Random.Next(minValue, maxValue - 1) it returns a value form the full range.
    /// </summary>
    /// <param name="minValue"></param>
    /// <param name="maxValue"></param>
    /// <returns>Random integer from range minValue maxValue</returns>
    public static int Roll(int minValue, int maxValue)
    {
        return _randomizer.Next(minValue, maxValue + 1);
    }
}

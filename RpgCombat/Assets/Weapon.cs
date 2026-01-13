namespace RpgCombat.Assets;

public class Weapon
{
    private Random _randomizer = new Random();
    public string Name { get; init; }
    public int MinDamage { get; init; }
    public int MaxDamage { get; init; }
    public Weapon(string name, int minDamage, int maxDamage)
    {
        Name = name;
        MinDamage = minDamage;
        MaxDamage = maxDamage;
    }

    public int RollDamage()
    {
        return _randomizer.Next(MinDamage, MaxDamage + 1);
    }
}

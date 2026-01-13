using RpgCombat.Core;

namespace RpgCombat.Abilities;

public class Heal : Ability
{
    private Random _randomizer = new Random();
    public Heal(string name)
    {
        Name = name;
    }

    public override void Use(Unit user, Unit target)
    {
        int healingValue = _randomizer.Next(1, 11);
        user.Heal(healingValue);
    }
}

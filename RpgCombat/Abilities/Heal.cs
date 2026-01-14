using RpgCombat.Core;

namespace RpgCombat.Abilities;

public class Heal : Ability
{
    public Heal(string name)
    {
        Name = name;
    }

    public override void Use(Unit user, Unit target)
    {
        Log($"{user.Name} heals using {this.Name}");
        int healingValue = Dice.Roll(1, 11);
        user.Heal(healingValue);
    }
}

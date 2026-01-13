using RpgCombat.Core;

namespace RpgCombat.Abilities;

public class Attack : Ability
{
    private Random _randomizer = new Random();
    public Attack(string name)
    {
        Name = name;
    }

    public override void Use(Unit user, Unit target)
    {
        int damageRolled = _randomizer.Next(user.Weapon.MinDamage, user.Weapon.MaxDamage + 1);
        target.TakeDamage(damageRolled);
    }
}

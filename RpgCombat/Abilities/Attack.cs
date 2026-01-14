using RpgCombat.Core;

namespace RpgCombat.Abilities;

public class Attack : Ability
{
    public Attack(string name)
    {
        Name = name;
    }

    public override void Use(Unit user, Unit target)
    {
        Log($"{user.Name} attacks {target.Name} using {this.Name}");
        int damageRolled = Dice.Roll(user.Weapon.MinDamage, user.Weapon.MaxDamage);
        target.TakeDamage(damageRolled);
    }
}

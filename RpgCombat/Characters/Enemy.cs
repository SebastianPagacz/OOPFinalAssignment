using RpgCombat.Abilities;
using RpgCombat.Assets;
using RpgCombat.Core;

namespace RpgCombat.Characters;

public class Enemy : Unit
{
    public Enemy(string name, int hp, Weapon weapon, List<Ability> abilities) : base(name, hp, weapon)
    {
        Abilities = abilities;
    }

}

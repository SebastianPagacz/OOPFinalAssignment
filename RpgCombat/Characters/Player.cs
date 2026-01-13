using RpgCombat.Abilities;
using RpgCombat.Assets;
using RpgCombat.Core;

namespace RpgCombat.Characters;

public class Player : Unit
{
    public Player(string name, Weapon weapon, List<Ability> abilities) : base(name, 100, weapon)
    {
        Abilities = abilities;
    }

}

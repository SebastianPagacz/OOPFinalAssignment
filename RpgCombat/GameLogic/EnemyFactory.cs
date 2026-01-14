using RpgCombat.Abilities;
using RpgCombat.Assets;
using RpgCombat.Characters;
using RpgCombat.Core;

namespace RpgCombat.GameLogic;

public class EnemyFactory : IFactory
{
    private List<string> _randomNames = new List<string> 
    {
        "Scur",
        "Drakula",
        "Golem"
    };

    public Unit SpawnUnit(string name, int hp, Weapon weapon, List<Ability> abilities)
    {
        Enemy result = new Enemy(name, hp, weapon, abilities);
        return result;
    }

    public Unit SpawnRandomUnit()
    {
        int minDamage = Dice.Roll(4, 9);
        int maxDamage = Dice.Roll(minDamage, minDamage * 2);
        Weapon weapon = new Weapon("Basic weapon", minDamage, maxDamage);
        var abilities = new List<Ability>();
        Ability a1 = new Attack("Basic Attack");
        abilities.Add(a1);

        return new Enemy(_randomNames[Dice.Roll(0, _randomNames.Count - 1)], Dice.Roll(25, 65), weapon, abilities);
    }
}

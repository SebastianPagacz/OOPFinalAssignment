using RpgCombat.Abilities;
using RpgCombat.Assets;
using RpgCombat.Characters;
using RpgCombat.Core;

namespace RpgCombat.GameLogic;

public class EnemyFactory : IFactory
{
    private Random _randomizer = new Random();

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
        int minDamage = _randomizer.Next(4, 9);
        int maxDamage = _randomizer.Next(minDamage, minDamage * 2);
        Weapon weapon = new Weapon("Basic weapon", minDamage, maxDamage);
        var abilities = new List<Ability>();
        Ability a1 = new Attack("Basic Attack");
        abilities.Add(a1);

        return new Enemy(_randomNames[_randomizer.Next(0, _randomNames.Count)], _randomizer.Next(25, 65), weapon, abilities);
    }
}

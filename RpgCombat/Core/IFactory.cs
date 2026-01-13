using RpgCombat.Assets;

namespace RpgCombat.Core;

public interface IFactory
{
    Unit SpawnUnit(string name, int hp, Weapon weapon, List<Ability> abilities);
    Unit SpawnRandomUnit();
}

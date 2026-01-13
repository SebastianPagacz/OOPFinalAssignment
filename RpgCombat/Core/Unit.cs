using RpgCombat.Assets;
using System.Collections;

namespace RpgCombat.Core;

public abstract class Unit
{
    // Observer pattern
    public event Action<string> OnLog;
    public string Name { get; init; }
    public int Hp { get; private set; }
    public int MaxHp { get; init; }
    public Weapon Weapon { get; init; }
    public List<Ability> Abilities { get; protected set; } = new List<Ability>();
    
    protected Unit(string name, int hp, Weapon weapon)
    {
        Name = name;
        Hp = hp;
        Weapon = weapon;
        MaxHp = hp;
    }

    public void TakeDamage(int damage)
    {
        if (damage < 0)
        {
            return;
        }

        Hp -= damage;

        OnLog?.Invoke($"{Name} got {damage} damage. {Name} Hp is {Hp}/{MaxHp}");

        if (Hp < 0)
        {
            Hp = 0;
        }

        if(Hp == 0)
        {
            OnLog?.Invoke($"{Name} has died!");
        }
    }

    public void Heal(int healingValue)
    {
        Hp += healingValue;

        if(Hp > MaxHp)
        {
            Hp = MaxHp;
        }

        OnLog?.Invoke($"{Name} heald for {healingValue}! Current health {Hp}/{MaxHp}");
    }

    public virtual void UseAbility(string abilityName, Unit target)
    {

        var abilityToUse = Abilities.FirstOrDefault(ability => ability.Name == abilityName);

        if (abilityToUse != null)
        {
            abilityToUse.Use(this, target);
        }
        else
        {
            OnLog?.Invoke($"{this.Name} does not know {abilityName}!");
        }
    }
}

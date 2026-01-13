namespace RpgCombat.Core;

public abstract class Ability
{
    public string Name { get; protected set; } = string.Empty;
    public abstract void Use(Unit user, Unit target);
}

namespace RpgCombat.Core;

public abstract class Ability
{
    public event Action<string> OnLog;
    public string Name { get; protected set; } = string.Empty;
    public abstract void Use(Unit user, Unit target);

    protected void Log(string message)
    {
        OnLog?.Invoke(message);
    }
}

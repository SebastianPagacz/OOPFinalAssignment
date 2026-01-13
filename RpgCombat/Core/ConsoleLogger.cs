namespace RpgCombat.Core;

public class ConsoleLogger
{
    public void WriteLog(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"[BATTLE_LOG]: {message}");
    }
}

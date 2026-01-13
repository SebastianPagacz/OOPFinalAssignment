using RpgCombat.Core;

namespace RpgCombat.GameLogic;

public class GameLoop
{
    public GameLoop(Unit player, Unit enemy)
    { 
        while(player.Hp > 0 && enemy.Hp > 0)
        {
            player.UseAbility("Basic Attack", enemy);
            Console.Read();

            if(enemy.Hp <= 0)
            {
                break;
            }
            enemy.UseAbility("Basic Attack", player);
            Console.Read();
            player.UseAbility("Heal", enemy);
            Console.Read();
        }
    }
}

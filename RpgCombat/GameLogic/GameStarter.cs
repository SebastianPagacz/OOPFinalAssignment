using RpgCombat.Abilities;
using RpgCombat.Assets;
using RpgCombat.Characters;
using RpgCombat.Core;

namespace RpgCombat.GameLogic;

public class GameStarter
{
    private ConsoleLogger _logger = new ConsoleLogger();
    public void StartGame()
    {
        _logger.RenderStartScreen();
        
        bool keepPlaying = true;
        
        while (keepPlaying)
        {
            // Creating random enemy using factory pattern
            Unit randomizedEnemy = CreateRandomEnemy();
            // Perdefined hero created  
            Player player = CreatePlayer();

            // console logger - single responibility class implemented with observer pattern
            ConnectLogger(player);
            ConnectLogger(randomizedEnemy);


            GameLoop gl = new GameLoop(player, randomizedEnemy);
            gl.OnLog += _logger.WriteLog;

            gl.Start();

            Console.WriteLine("Do you wish to play again? [y/n]");
            string? input = Console.ReadLine();
            if (input?.ToLower()[0] != 'y')
            {
                keepPlaying = false;
                Console.WriteLine("Closing app...");
            }
            else
            {
                Console.Clear();
            }
        }
    }

    private Player CreatePlayer()
    {
        List<Ability> playersAbilities = new List<Ability>();
        Attack basicAttack = new Attack("Basic attack");
        Heal heal = new Heal("Heal");
        playersAbilities.Add(basicAttack);
        playersAbilities.Add(heal);

        Weapon playersWeapon = new Weapon("Sword", 18, 26);

        return new Player("Gracz", playersWeapon, playersAbilities);
    }

    private Unit CreateRandomEnemy()
    {
        EnemyFactory enemyFactory = new EnemyFactory();
        return enemyFactory.SpawnRandomUnit();
    }

    private void ConnectLogger(Unit unit)
    {
        unit.OnLog += _logger.WriteLog;

        foreach(var ability in unit.Abilities)
        {
            ability.OnLog += _logger.WriteLog;
        }
    }
}

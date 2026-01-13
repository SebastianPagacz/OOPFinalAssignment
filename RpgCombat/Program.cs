using RpgCombat.Abilities;
using RpgCombat.Assets;
using RpgCombat.Characters;
using RpgCombat.Core;
using RpgCombat.GameLogic;

namespace RpgCombat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnemyFactory enemyFactory = new EnemyFactory();
            var randomizedEnemy = enemyFactory.SpawnRandomUnit();

            ConsoleLogger logger = new ConsoleLogger();

            var as1 = new List<Ability>();
            var a1 = new Attack("Basic Attack");
            var h1 = new Heal("Heal");
            as1.Add(a1);
            as1.Add(h1);

            Weapon w1 = new Weapon("mieczywko", 20, 26);
            Weapon w2 = new Weapon("pazurki", 10, 13);
            Player p1 = new Player("testowy ziomek", w1, as1);

            p1.OnLog += logger.WriteLog;
            randomizedEnemy.OnLog += logger.WriteLog;

            GameLoop gl1 = new GameLoop(p1, randomizedEnemy);
        }
    }
}

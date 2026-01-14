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
            GameStarter starter = new GameStarter();
            starter.StartGame();
        }
    }
}

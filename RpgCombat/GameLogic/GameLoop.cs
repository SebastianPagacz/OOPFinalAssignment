using RpgCombat.Core;

namespace RpgCombat.GameLogic;

public class GameLoop
{
    public Action<string> OnLog;
    public Unit Player { get; set; }
    public Unit Enemy { get; set; }
    public GameLoop(Unit player, Unit enemy)
    { 
        Player = player;
        Enemy = enemy;
    }

    private void PlayersTurn()
    {
        bool validChoice = false;
        while (!validChoice)
        {
            OnLog?.Invoke("Choose your Ability:");

            int counter = 1;
            foreach (var item in Player.Abilities)
            {
                OnLog?.Invoke($"{counter}. {item.Name}");
                counter++;
            }

            var playersInput = Console.ReadLine();

            if(int.TryParse(playersInput, out int choice) && choice > 0 && choice <= Player.Abilities.Count)
            {
                Player.Abilities[choice - 1].Use(Player, Enemy);

                validChoice = true;
            }
            else
            {
                OnLog?.Invoke("Choice is not valid - index number of the ability");
            }
        }
    }

    private void EnemmysTurn()
    {
        int randomAbility = Dice.Roll(0, Enemy.Abilities.Count - 1);

        Enemy.Abilities[randomAbility].Use(Enemy, Player);
    }

    public void Start()
    {
        while (Player.Hp > 0 && Enemy.Hp > 0) 
        {
            PlayersTurn();

            if(Enemy.Hp <= 0)
            {
                break;
            }

            OnLog?.Invoke("...press any button to continue\n");
            Console.ReadKey();

            EnemmysTurn();

            if (Player.Hp <= 0)
            {
                break;
            }

            OnLog?.Invoke("...press any button to continue\n");
            Console.ReadKey();
        }
        OnLog?.Invoke("The game has ended!");
        Console.ReadKey();
    }
}

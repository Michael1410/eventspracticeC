using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /*
            Initiative initiative = new Initiative();

            // Add players and generate their initiatives
            initiative.InitiativeRandomNumber("Player1", 14);
            initiative.InitiativeRandomNumber("Player2", 16);

            initiative.PrintInitiative();
            */

            List<Player> PlayersInBattle = new List<Player>();
            List<Player> SortedPlayersInBattle = new List<Player>();

            Player player1 = new Player( "Aragorn", 100, 20, 10, 
                                        18, 14, 14, 14, 20, 16, 
                                        21, 2, 2, 2, 2, 6, 4, 7, 8, 10, 5, 
                                        10, 10, 10, 2, 2, 2,
                                        22, 15, false);

            Player player2 = new Player( "Urukai", 100, 20, 10, 
                                        18, 14, 14, 14, 20, 16, 
                                        21, 2, 2, 2, 2, 6, 4, 7, 8, 10, 5, 
                                        10, 10, 10, 2, 2, 2,
                                        22, 12, false);

            PlayersInBattle.Add(player1);
            PlayersInBattle.Add(player2);

            Initiative initiative = new Initiative();

            // Add players and generate their initiatives
            initiative.InitiativeRandomNumber(player1);
            initiative.InitiativeRandomNumber(player2);

            initiative.PrintInitiative();

        }

        
    }
}
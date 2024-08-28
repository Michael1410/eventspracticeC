using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Initiative
    {

        Dictionary<string, int> PlayerInitiatives = new Dictionary<string, int>();

        public void InitiativeRandomNumber(Player player)
        {
            Random random = new Random();
            int GenerateInitiative = random.Next(1,player.initiatives);
            PlayerInitiatives[player.Name] = GenerateInitiative;
        }

        public void PrintInitiative()
        {
            System.Console.WriteLine("Generated Initiative: ");
            PlayerInitiatives.OrderByDescending(p => p.Value);
            foreach (var player in PlayerInitiatives)
            {
                Console.WriteLine($"{player.Key}: {player.Value}");
            }
        }
    }

}
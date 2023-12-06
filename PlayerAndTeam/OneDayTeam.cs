using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeam
{
    public class OneDayTeam:Team
    {
        public static List<Player> oneDayTeam = new List<Player>();

        // Constructor to set the capacity property to 11
        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }

        public void Add(Player player)
        {
            oneDayTeam.Add(player);
            Console.WriteLine($"{player.PlayerName} added to the team.");
        }

        public void Remove(int playerId)
        {
            Player playerToRemove = oneDayTeam.Find(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine($"{playerToRemove.PlayerName} removed from the team.");
            }
            else
            {
                Console.WriteLine($"Player with ID {playerId} not found in the team.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.Find(p => p.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.Find(p => p.PlayerName == playerName);
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}

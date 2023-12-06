using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeam
{
    public class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam oneDayTeam = new OneDayTeam();

            while (true)
            {
                Console.WriteLine("Enter 1: To Add Player  2: To Remove Player by Id  3: Get Player By Id  4: Get Player by Name  5: Get All Players:");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Player Id:");
                        int playerId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Player Name:");
                        string playerName = Console.ReadLine();
                        Console.WriteLine("Enter Player Age:");
                        int playerAge = Convert.ToInt32(Console.ReadLine());

                        Player newPlayer = new Player { PlayerId = playerId, PlayerName = playerName, PlayerAge = playerAge };
                        oneDayTeam.Add(newPlayer);
                        break;

                    case 2:
                        Console.WriteLine("Enter Player Id to remove:");
                        int removePlayerId = Convert.ToInt32(Console.ReadLine());
                        oneDayTeam.Remove(removePlayerId);
                        break;

                    case 3:
                        Console.WriteLine("Enter Player Id to get details:");
                        int getPlayerId = Convert.ToInt32(Console.ReadLine());
                        Player getPlayer = oneDayTeam.GetPlayerById(getPlayerId);
                        Console.WriteLine($"Player Details: Id - {getPlayer.PlayerId}, Name - {getPlayer.PlayerName}, Age - {getPlayer.PlayerAge}");
                        break;

                    case 4:
                        Console.WriteLine("Enter Player Name to get details:");
                        string getPlayerName = Console.ReadLine();
                        Player getPlayerByName = oneDayTeam.GetPlayerByName(getPlayerName);
                        Console.WriteLine($"Player Details: Id - {getPlayerByName.PlayerId}, Name - {getPlayerByName.PlayerName}, Age - {getPlayerByName.PlayerAge}");
                        break;

                    case 5:
                        List<Player> allPlayers = oneDayTeam.GetAllPlayers();
                        Console.WriteLine("All Players in the Team:");
                        foreach (var player in allPlayers)
                        {
                            Console.WriteLine($"Id - {player.PlayerId}, Name - {player.PlayerName}, Age - {player.PlayerAge}");
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }
    }
}

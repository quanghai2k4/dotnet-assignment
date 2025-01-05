using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManagement.Models;

namespace VideoGameManagement.Views;
internal class GameView
{
    public void ShowGame(Game game)
    {
        if (game == null)
        {
            Console.WriteLine("Game not found");
            return;
        }
        else
        {
            Console.WriteLine($"Id: {game.Id}");
            Console.WriteLine($"Title: {game.Title}");
            Console.WriteLine($"Genre: {game.Genre}");
            Console.WriteLine($"Platform: {game.Platform}");
            Console.WriteLine($"Year: {game.Year}");
            Console.WriteLine($"Description: {game.Description}");
        }
    }
    public void ShowAllGames(List<Game> games)
    {
        foreach (var game in games)
        {
            Console.WriteLine($"Id: {game.Id}");
            Console.WriteLine($"Title: {game.Title}");
            Console.WriteLine($"Genre: {game.Genre}");
            Console.WriteLine($"Platform: {game.Platform}");
            Console.WriteLine($"Year: {game.Year}");
            Console.WriteLine($"Description: {game.Description}");
            Console.WriteLine();
        }
    }
}

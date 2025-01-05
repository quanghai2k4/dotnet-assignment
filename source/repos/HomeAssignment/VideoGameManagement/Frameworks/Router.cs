using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManagement.Controllers;

namespace VideoGameManagement.Frameworks;
internal static class Router
{
    static GameController _gameController = new();
    static MainController _mainController = new();

    public static void Forward(string[] args)
    {
        var command = args[0].ToLower();
        switch (command)
        {
            case "menu":
                _mainController.ShowMenu();
                break;
            case "add":
                if (args.Length < 7)
                {
                    Console.WriteLine("Invalid command");
                    return;
                }
                var description = string.Join(" ", args.Skip(6));
                _gameController.AddGame(args[1], args[2], args[3], args[4], args[5], description);
                break;
            case "remove":
                if (args.Length < 2)
                {
                    Console.WriteLine("Invalid command");
                    return;
                }
                _gameController.RemoveGame(args[1]);
                break;
            case "removeall":
                _gameController.ClearAllGames();
                break;
            case "list":
                _gameController.ListAllGames();
                break;
            case "get":
                if (args.Length < 2)
                {
                    Console.WriteLine("Invalid command");
                    return;
                }
                _gameController.ListGame(args[1]);
                break;
            case "clr":
                _mainController.Clear();
                break;
            case "exit":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid command");
                break;
        }
    }
}

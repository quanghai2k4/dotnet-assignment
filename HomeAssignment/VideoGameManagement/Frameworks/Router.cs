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
                _gameController.AddView();
                break;
            case "add_confirmed":
                if (args.Length < 6)
                {
                    Console.WriteLine("Invalid command");
                    return;
                }
                _gameController.AddGame(args[1], args[2], args[3], args[4], args[5], args[6]);
                break;
            case "remove":
                if (args.Length < 2)
                {
                    Console.WriteLine("Invalid command");
                    return;
                }
                if (args[1].ToLower() == "-all")
                {
                    Console.Write("Are you sure you want to remove all games? (yes/no): ");
                    var confirmation = Console.ReadLine();
                    if (confirmation?.ToLower() == "yes")
                    {
                        _gameController.ClearAllGames();
                    }
                    else
                    {
                        Console.WriteLine("Operation cancelled.");
                    }
                }
                else
                {
                    _gameController.RemoveGame(args[1]);
                }
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

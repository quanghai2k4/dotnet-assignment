using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManagement.Models;
using VideoGameManagement.Repositories;
using VideoGameManagement.Views;

namespace VideoGameManagement.Controllers;
internal class GameController
{
    GameRepos _gameRepos = new();
    GameView _gameView = new();

    public void AddGame(string id, string title, string genre, string platform, string year, string description)
    {
        var game = new Game
        {
            Id = id,
            Title = title,
            Genre = genre,
            Platform = platform,
            Year = year,
            Description = description
        };
        _gameRepos.AddGame(game);
    }

    public void RemoveGame(string id)
    {
        _gameRepos.RemoveGame(id);
    }
    public void ClearAllGames()
    {
        _gameRepos.ClearAllGames();
    }
    public void ListAllGames()
    {
        var games = _gameRepos.GetAllGames();
        _gameView.ShowAllGames(games);
    }
    public void ListGame(string id)
    {
        var game = _gameRepos.GetGame(id);
        _gameView.ShowGame(game);
    }

    public Game GetGame(string title)
    {
        return _gameRepos.GetGame(title);
    }

    public List<Game> GetAllGames()
    {
        return _gameRepos.GetAllGames();
    }
}

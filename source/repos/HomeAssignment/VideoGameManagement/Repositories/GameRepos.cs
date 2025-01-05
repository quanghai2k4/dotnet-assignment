using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoGameManagement.Models;

namespace VideoGameManagement.Repositories;
internal class GameRepos
{
    private List<Game> _games = new List<Game>
    {
        new Game
        {
            Id = "1",
            Title = "The Legend of Zelda: Breath of the Wild",
            Genre = "Action-adventure",
            Platform = "Nintendo Switch",
            Year = "2017",
            Description = "The Legend of Zelda: Breath of the Wild is an action-adventure game developed and published by Nintendo. An entry in the longrunning The Legend of Zelda series, it was released for the Nintendo Switch and Wii U consoles on March 3, 2017."
        },
        new Game
        {
            Id = "2",
            Title = "Super Mario Odyssey",
            Genre = "Platform",
            Platform = "Nintendo Switch",
            Year = "2017",
            Description = "Super Mario Odyssey is a platform game developed and published by Nintendo for the Nintendo Switch. An entry in the Super Mario series, it follows Mario and Cappy, a spirit that turns into Mario's hat and allows him to possess other characters and objects, as they journey across various worlds to save Princess Peach from his nemesis Bowser, who plans to forcibly marry her."
        },
        new Game
        {
            Id = "3",
            Title = "The Witcher 3: Wild Hunt",
            Genre = "Action role-playing",
            Platform = "PlayStation 4",
            Year = "2015",
            Description = "The Witcher 3: Wild Hunt is a 2015 action role-playing game developed and published by CD Projekt. Based on The Witcher series of fantasy novels by Polish author Andrzej Sapkowski, it is the sequel to the 2011 game The Witcher 2: Assassins of Kings."
        }
    };
    public void AddGame(Game game)
    {
        _games.Add(game);
    }
    public void RemoveGame(string id)
    {
        var gameToRemove = _games.FirstOrDefault(g => g.Id == id);
        if (gameToRemove != null)
        {
            _games.Remove(gameToRemove);
        }
    }
    public void ClearAllGames()
    {
        _games.Clear();
    }
    public Game GetGame(string id)
    {
        return _games.FirstOrDefault(g => g.Id == id);
    }
    public List<Game> GetAllGames()
    {
        return _games;
    }
}

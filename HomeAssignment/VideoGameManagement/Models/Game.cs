using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameManagement.Models;

internal class Game
{
    public string Id { get; set; }
    public string Title { get; set; }
    public string Genre { get; set; }
    public string Platform { get; set; }
    public string Year { get; set; }
    public string Description { get; set; }
}

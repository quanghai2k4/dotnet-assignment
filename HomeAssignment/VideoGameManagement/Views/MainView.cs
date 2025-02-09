using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoGameManagement.Views;
internal class MainView
{
    public void ShowMenu()
    {
        Console.WriteLine("Commands:");
        Console.WriteLine("add <id> <title> <genre> <platform> <year> <description>");
        Console.WriteLine("remove <id>");
        Console.WriteLine("removeall");
        Console.WriteLine("list");
        Console.WriteLine("get <id>");
    }
    public void Clear()
    {
        Console.Clear();
    }
}

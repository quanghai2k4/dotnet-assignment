using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.Views;
internal class MainView
{
    public void Help()
    {
        Console.WriteLine("add - add new course");
        Console.WriteLine("list - display all courses");
        Console.WriteLine("remove-all - remove all courses");
        Console.WriteLine("remove?name=course1&name=course2 - remove courses");
        Console.WriteLine("clr - clear console");
        Console.WriteLine("help - display menu");
        Console.WriteLine("exit - exit app");
    }
    public void Clear()
    {
        Console.Clear();
    }
}

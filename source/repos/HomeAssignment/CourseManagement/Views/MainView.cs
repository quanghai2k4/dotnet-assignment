﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagement.Views;
internal class MainView
{
    public void DisplayMenu()
    {
        Console.WriteLine("Welcom to Course Management!");
        Console.WriteLine("add <name> <credit> <description> <semester> - add new course");
        Console.WriteLine("list - display all courses");
        Console.WriteLine("remove - remove all courses");
        Console.WriteLine("clr - clear console");
        Console.WriteLine("help - display menu");
        Console.WriteLine("exit - exit app");
    }
    public void Clear()
    {
        Console.Clear();
    }
}

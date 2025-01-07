using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.Controllers;

namespace CourseManagement.Frameworks;
internal class Route
{
    static CourseController _courseController = new();
    static MainController _mainController = new();
    public static void Forward(string[] args)
    {
        if (args.Length == 0)
        {
            _mainController.ShowMenu();
            return;
        }
        switch (args[0])
        {
            case "add":
                if (args.Length < 5)
                {
                    Console.WriteLine("Invalid arguments");
                    return;
                }
                _courseController.AddCourse(new()
                {
                    Name = args[1],
                    Credit = int.Parse(args[2]),
                    Description = args[3],
                    Semester = args[4]
                });
                break;
            case "remove":
                //if (args.Length < 2)
                //{
                //    Console.WriteLine("Invalid arguments");
                //    return;
                //}
                //_courseController.RemoveCourse(new()
                //{
                //    Name = args[1]
                //});
                if (args.Length < 2)
                {
                    Console.WriteLine("Invalid arguments");
                    return;
                }
                var courseNames = args.Skip(1).ToList();
                _courseController.RemoveCourses(courseNames);
                break;
            case "clear":
                _courseController.ClearCourses();
                break;
            case "list":
                _courseController.DisplayCourses();
                break;
            case "help":
                _mainController.ShowMenu();
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

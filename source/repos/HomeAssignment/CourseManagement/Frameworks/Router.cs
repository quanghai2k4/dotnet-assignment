using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.Controllers;

namespace CourseManagement.Frameworks
{
    internal class Router
    {
        static CourseController _courseController = new();
        static MainController _mainController = new();
        public static void Forward(string input)
        {
            var command = input.Split('?')[0].ToLower();
            var param = Params(input);
            switch (command)
            {
                case "add":
                    _courseController.AddView();
                    break;
                case "add_course":
                    _courseController.AddCourse(param);
                    break;
                case "remove":
                    _courseController.RemoveView();
                    break;
                case "remove_confirmed":
                    _courseController.RemoveCourses(new List<string> { param["name"] });
                    break;
                case "remove_all":
                    _courseController.ClearCourses();
                    break;
                case "list":
                    _courseController.DisplayCourses();
                    break;
                case "help":
                    _mainController.ShowHelp();
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

        static Dictionary<string, string> Params(string query)
        {
            var param = query.Split(new[] { '?', '&' }, StringSplitOptions.RemoveEmptyEntries);
            var result = new Dictionary<string, string>();
            for (int i = 1; i < param.Length; i++)
            {
                var keyValue = param[i].Split("=");
                if (keyValue.Length >= 2)
                {
                    result[keyValue[0]] = keyValue[1];
                }
                else
                {
                    Console.WriteLine($"Invalid parameter format: {param[i]}");
                }
            }
            return result;
        }
    }
}

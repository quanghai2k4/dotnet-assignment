using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.Frameworks;
using CourseManagement.Models;

namespace CourseManagement.Views;

internal class CourseView
{
    public void DisplayCourses(List<Course> courses)
    {
        foreach (var course in courses)
        {
            Console.WriteLine(
                $"Name: {course.Name}, Credit: {course.Credit}, Description: {course.Description}, Semester: {course.Semester}"
            );
        }
    }

    public void AddView()
    {
        Console.WriteLine("Enter the course name:");
        var name = Console.ReadLine();
        Console.WriteLine("Enter the course credit:");
        var credit = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the course description:");
        var description = Console.ReadLine();
        Console.WriteLine("Enter the course semester:");
        var semester = Console.ReadLine();

        Router.Forward(
            $"add_course?name={name}&credit={credit}&description={description}&semester={semester}"
        );
    }

    public void RemoveView()
    {
        Console.WriteLine("Enter the course name:");
        var name = Console.ReadLine();
        Router.Forward($"remove_confirmed?name={name}");
    }
}

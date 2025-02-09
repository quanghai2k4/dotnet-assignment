using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.Models;
using CourseManagement.Repositories;
using CourseManagement.Views;

namespace CourseManagement.Controllers;

internal class CourseController
{
    CourseRepo _courseRepo = new CourseRepo();
    CourseView _courseView = new CourseView();

    public void AddView()
    {
        _courseView.AddView();
    }

    public void AddCourse(Dictionary<string, string> command)
    {
        var course = new Course
        {
            Name = command["name"],
            Credit = int.Parse(command["credit"]),
            Description = command["description"],
            Semester = command["semester"],
        };
        _courseRepo.AddCourse(course);
    }

    public void RemoveView()
    {
        _courseView.RemoveView();
    }

    public void RemoveCourses(List<string> courseNames)
    {
        _courseRepo.RemoveCourses(courseNames);
    }

    public void ClearCourses()
    {
        _courseRepo.ClearCourses();
    }

    public void DisplayCourses()
    {
        var courses = _courseRepo.GetCourses();
        _courseView.DisplayCourses(courses);
    }
}

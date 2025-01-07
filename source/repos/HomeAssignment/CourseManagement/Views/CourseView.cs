using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.Models;

namespace CourseManagement.Views;
internal class CourseView
{
    public void DisplayCourses(List<Course> courses)
    {
        foreach (var course in courses)
        {
            Console.WriteLine($"Name: {course.Name}, Credit: {course.Credit}, Description: {course.Description}, Semester: {course.Semester}");
        }
    }
}

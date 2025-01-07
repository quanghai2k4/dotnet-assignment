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

    public void AddCourse(Course course)
    {
        _courseRepo.AddCourse(course);
    }
    //public void RemoveCourse(Course course)
    //{
    //    _courseRepo.RemoveCourse(course);
    //}
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

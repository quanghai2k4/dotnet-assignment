using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourseManagement.Models;

namespace CourseManagement.Repositories;
internal class CourseRepo
{
    private List<Course> _courses = new List<Course>
    {
        new Course { Name = "Math", Credit = 3, Description = "Mathematics", Semester = "Fall" },
        new Course { Name = "Science", Credit = 4, Description = "Science", Semester = "Spring" },
        new Course { Name = "History", Credit = 3, Description = "History", Semester = "Fall"},
        new Course { Name = "English", Credit = 3, Description = "English", Semester = "Spring" },
        new Course { Name = "Computer", Credit = 3, Description = "Computer", Semester = "Fall" },
        new Course { Name = "Art", Credit = 3, Description = "Art", Semester = "Spring" },
        new Course { Name = "Music", Credit = 3, Description = "Music", Semester = "Fall" },
    };
    public void AddCourse(Course course)
    {
        _courses.Add(course);
    }
    //public void RemoveCourse(Course course)
    //{
    //    var courseName = _courses.FirstOrDefault(c => c.Name == course.Name);
    //    if (courseName != null)
    //    {  
    //        _courses.Remove(courseName); 
    //    }
    //}
    public void RemoveCourses(List<string> courseNames)
    {
        _courses.RemoveAll(c => courseNames.Contains(c.Name));
    }
    public void ClearCourses()
    {
        _courses.Clear();
    }
    public List<Course> GetCourses()
    {
        return _courses;
    }
}

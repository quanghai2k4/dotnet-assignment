using CourseManagement.Frameworks;

namespace CourseManagement;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Course Management System");
        while (true)
        {
            Console.Write(">>>> ");
            var command = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(command))
            {
                continue;
            }
            Router.Forward(command);
        }
    }
}

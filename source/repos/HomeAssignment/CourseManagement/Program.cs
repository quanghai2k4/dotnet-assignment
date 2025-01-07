namespace CourseManagement;
using CourseManagement.Frameworks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Course Management System");
        while (true)
        {
            Console.Write(">>>> ");
            var command = Console.ReadLine();
            Route.Forward(command.Split(' '));
        }
    }
}

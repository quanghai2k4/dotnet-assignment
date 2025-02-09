using VideoGameManagement.Frameworks;

namespace VideoGameManagement;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Video Game Management System");
        while (true)
        {
            Console.Write(">>>>> ");
            var command = Console.ReadLine();
            Router.Forward(command.Split(' '));
        }
    }
}

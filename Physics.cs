namespace ConsoleApp1;

public class Physics
{
    public Physics()
    {
        Console.WriteLine("What physics equation do you want to use (use full name and use lowercase): ");
        var physics = Console.ReadLine();

        switch (physics)
        {
            case "density":
                Console.WriteLine("density");
                break;
        }
    }
}
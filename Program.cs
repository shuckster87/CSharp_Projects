namespace ConsoleApp1;

internal static class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to the Math Calculator, what type of math do you want to do today? (use simple for normal equations): ");
        var input = Console.ReadLine();
        switch (input)
        {
            case "simple":
                var simple = new SimpleMath();
                break;
            case "algebra":
                var algebra = new Algebra();
                break;
            case "physics":
                var physics = new Physics();
                break;
        }
    }
}
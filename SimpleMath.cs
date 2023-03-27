namespace ConsoleApp1;

public class SimpleMath
{
    public SimpleMath()
    {
        Console.WriteLine("Enter a number: ");
        var num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number: ");
        var num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What do you want to do with these numbers? (use full name and use lowercase): ");
        var expression = Console.ReadLine();

        switch (expression)
        {
            case "addition":
            {
                var add = num1 + num2;
                Console.WriteLine("The result of adding {0} and {1} is: {2}", num1, num2, add);
                break;
            }
            case "subtraction":
            {
                var sub = num1 - num2;
                Console.WriteLine("The result of subtracting {0} and {1} is: {2}", num1, num2, sub);
                break;
            }
            case "multiplication":
            {
                var mult = num1 * num2;
                Console.WriteLine("The result of multiplying {0} and {1} is: {2}", num1, num2, mult);
                break;
            }
            case "division":
            {
                var div = num1 / num2;
                Console.WriteLine("The result of dividing {0} and {1} is: {2}", num1, num2, div);
                break;

            }
            default:
            {
                Console.WriteLine("ERROR! nothing has been put down. Try again!");
                break;
            }
        }
    }
}
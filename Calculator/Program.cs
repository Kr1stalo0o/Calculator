Console.WriteLine("enter the first number:");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("enter second number:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine("enter a mathematical operation (+, -, *, /):");
string operation = Console.ReadLine();

switch (operation)
{
    case "+":
        Console.WriteLine($"result: {num1 + num2}");
        break;
    case "-":
        Console.WriteLine($"result: {num1 - num2}");
        break;
    case "*":
        Console.WriteLine($"result: {num1 * num2}");
        break;
    case "/":
        if (num2 != 0)
        {
            Console.WriteLine($"result: {num1 / num2}");
        }
        else
        {
            Console.WriteLine("error: division by zero is not possible.");
        }
        break;
    default:
        Console.WriteLine("Error: unknown math operation.");
        break;
}
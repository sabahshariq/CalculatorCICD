using CalculatorCICD;

//Console.WriteLine("Hello, World!");

Calculator calc = new Calculator();

Console.WriteLine("===== Simple Calculator =====");

Console.WriteLine("Enter first number: ");
double firstNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second number: ");
double secondNumber = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Choose operation:");
Console.WriteLine("1 - Add");
Console.WriteLine("2 - Subtract");
Console.WriteLine("3 - Multiply");
Console.WriteLine("4 - Divide");

Console.Write("Choice: ");
string? choice = Console.ReadLine();

double result;

switch(choice)
{
    case "1":
        result = calc.Add(firstNumber, secondNumber);
        break;

    case "2":
        result = calc.Subtract(firstNumber, secondNumber);
        break;

    case"3":
        result = calc.Multiply(firstNumber, secondNumber);
        break;

    case"4":
        result = calc.Divide(firstNumber, secondNumber);
        break;

    default:
        Console.WriteLine("Invalid operation.");
        return;
}

Console.WriteLine("Result: " + result);

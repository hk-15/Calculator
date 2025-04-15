// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the calculator.");
Console.WriteLine("==========================");
Console.Write("Please enter an operator: ");
string op = Console.ReadLine();
Console.Write("How many numbers do you want to " + op + "?: ");
int[] numbers = new int[int.Parse(Console.ReadLine())];

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write("Please enter number " + (i + 1) + ": ");
    numbers[i] = int.Parse(Console.ReadLine());
}

int result = 0;

for (int i = 0; i < numbers.Length; i++)
{
    switch (op)
    {
        case "+":
            result += numbers[i];
            break;
        case "-":
            result -= numbers[i];
            break;
        case "*":
            result *= numbers[i];
            break;
        case "/":
            result /= numbers[i];
            break;
        default:
            Console.WriteLine("Please enter a valid operator.");
            break;
    }
}

Console.WriteLine("The result is: " + result);

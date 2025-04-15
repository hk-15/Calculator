// See https://aka.ms/new-console-template for more information

Console.WriteLine("Welcome to the calculator.");
Console.WriteLine("==========================");
Console.Write("Please enter a number: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Please enter another number: ");
int secondNumber = int.Parse(Console.ReadLine());
int result = firstNumber * secondNumber;
Console.WriteLine("The result is: " + result);
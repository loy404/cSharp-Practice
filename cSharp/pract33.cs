// 33. Print the greater of two numbers.

Console.WriteLine("Enter the first number: ");
int numOne = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int numTwo = int.Parse(Console.ReadLine());

if (numOne > numTwo)
{
    Console.WriteLine(numOne + " is greater number");
}
else if (numTwo > numOne)
{
    Console.WriteLine(numTwo + " is greater number");

}
else
{
    Console.WriteLine("Numbers are the same");
}

Console.WriteLine();
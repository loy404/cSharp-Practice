// 34. Print the largest of three numbers.

Console.WriteLine("Enter the first number: ");
int numOne = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the second number: ");
int numTwo = int.Parse(Console.ReadLine());

Console.WriteLine("Enter the third number: ");
int numThree = int.Parse(Console.ReadLine());

int largest = numOne;

if (numTwo > largest)
{
    largest = numTwo;
}
if (numThree > largest)
{
    largest = numThree;
}

Console.WriteLine("The largest number is: " + largest);

Console.WriteLine();
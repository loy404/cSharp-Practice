// 27. Validate age is between 0–120.

Console.Write("Enter age: ");
int age = int.Parse(Console.ReadLine());

if (age >= 0 && age <= 120)
{
    Console.Write("Valid age.");
}
else
{
    Console.Write("Not valid age.");
}
Console.WriteLine();    
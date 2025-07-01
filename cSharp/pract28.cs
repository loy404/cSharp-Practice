// 28. Ask for gender input (M/F) and greet accordingly.

Console.Write("Enter gender (M/F): ");
char gender = char.ToUpper(Console.ReadLine()[0]);


if (gender == 'M')
{
    Console.WriteLine("Hello, you're Male");
}
else if (gender == 'F')
{
    Console.WriteLine("Hello, you're Woman");
}
else
{
    Console.WriteLine("Gender not valid.");
}

Console.WriteLine();

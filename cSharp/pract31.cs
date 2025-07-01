// 31. Check if a number is divisible by both 3 and 5.

Console.WriteLine("Enter a number: ");
int num = int.Parse(Console.ReadLine());

if (num % 3 == 0 && num % 5 == 0)
{
    Console.WriteLine("Divisible by 3 and 5");
}
else if (num % 3 == 0)
{
    Console.WriteLine("Divisible by 3");
}
else if (num % 5 == 0)
{
    Console.WriteLine("Divisible by 5");
}
else
{
    Console.WriteLine("Not divisible by 3 and 5");
}

Console.WriteLine();

// 36. Check if a year is a leap year.

Console.WriteLine("Enter a year: ");
int userYear = int.Parse(Console.ReadLine());

if ((userYear % 4 == 0 && userYear % 100 != 0) || userYear % 400 == 0)
{
    Console.WriteLine("This is year leap year");
}
else
{
    Console.WriteLine("Not a leap year");
}

Console.WriteLine();
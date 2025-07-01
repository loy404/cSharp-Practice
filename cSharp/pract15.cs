// 15. Ask for full name input, then display only the initials.

Console.Write("Enter your full name: ");
string fullName = Console.ReadLine();

// Split the name by spaces
string[] names = fullName.Split(' ');

// Display initials
Console.Write("Your initials are: ");
foreach (string name in names)
{
    if (!string.IsNullOrEmpty(name))
    {
        Console.Write(char.ToUpper(name[0]));
    }
}
Console.WriteLine(); // to move to the next line

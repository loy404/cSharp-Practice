// 35. Greet with "Welcome, Admin!" if input is "admin".

Console.WriteLine("Enter username: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "admin")
{
    Console.WriteLine("Welcome, Admin!");
}
else
{
    Console.WriteLine("Invalid username.");
}

Console.WriteLine();
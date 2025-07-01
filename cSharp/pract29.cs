// 29. Ask if the user is student/teacher and greet appropriately.

Console.Write("Are you a teacher or a student (t/s): ");
string position = Console.ReadLine().ToLower();  // makes input lowercase

if (position == "t")
{
    Console.WriteLine("Hello Teacher!");
}
else if (position == "s")
{
    Console.WriteLine("Hello Student!");
}
else
{
    Console.WriteLine("Position not valid.");
}

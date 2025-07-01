// 30. If mark < 75, print "Fail", otherwise "Pass".

Console.Write("Enter your grade: ");
double grade = double.Parse(Console.ReadLine());

if (grade < 75)
{
    Console.WriteLine("Fail");
}
else
{
    Console.WriteLine("Pass");
}

Console.WriteLine();

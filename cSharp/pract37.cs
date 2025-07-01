/* 37. Ask the user to enter a numerical score between 0 and 100. 
Then convert and display the equivalent letter grade using the following scale:

90–100:A
80–89: B
70–79: C
60–69: D
Below 60: F 
*/

Console.WriteLine("Enter your score: ");
int score = int.Parse(Console.ReadLine());

int passing = 75;

if (score >= 90 && score <= 100)
{
    Console.WriteLine("Your grade is: A");
}
else if (score >= 80 && score <= 89)
{
    Console.WriteLine("Your grade is: B");
}
else if (score >= 70 && score <= 79)
{
    Console.WriteLine("Your grade is: C");
}
else if (score >= 60 && score <= 69)
{
    Console.WriteLine("Your grade is: D");
}
else
{
    Console.WriteLine("Below 60 your grade is: F");
}

Console.WriteLine();
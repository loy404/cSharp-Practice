// 23. Ask for three numbers, calculate and show the average.

Console.Write("Enter the first number: ");
int firstNum = int.Parse(Console.ReadLine());

Console.Write("Enter the second number: ");
int secondNum = int.Parse(Console.ReadLine());

Console.Write("Enter the third number: ");
int thirdNum = int.Parse(Console.ReadLine());

int total = firstNum + secondNum + thirdNum;
double average = total / 3.0;

Console.Write("Average: " + Math.Round(average,2));
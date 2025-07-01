// 16. Get a floating-point number and round it to 2 decimal places.

using System.ComponentModel;

Console.Write("Input a floating-point number: ");
double number = double.Parse(Console.ReadLine());

double rounded = Math.Round(number, 2);

Console.WriteLine("Rounded: " + rounded);






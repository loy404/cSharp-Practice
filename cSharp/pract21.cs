// 21. Ask the user to enter the temperature in Fahrenheit. 
// Then convert it to Celsius and show the result.

Console.Write("Input the temperature in Fahrenheit: ");
double fahrenheit = double.Parse(Console.ReadLine());

double celsius = (fahrenheit - 32) * 5 / 9;

Console.Write("Fahrenheit to Celsius is " + Math.Round(celsius, 2));
 
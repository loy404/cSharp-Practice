// 20. Ask the user to enter the temperature in Celsius. Then convert it to 
// Fahrenheit and show the result.

Console.WriteLine("Input the temperature in celsius: ");
double celsius = double.Parse(Console.ReadLine());

double fahrenheit = (celsius * 9 / 5) + 32;

Console.Write("Celsius to Fahrenheit is " + Math.Round(fahrenheit, 2)); 

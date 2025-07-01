// 18. Ask the user to enter the radius of a circle. Then show the area of that circle.


Console.WriteLine("Enter the radius of a circle: ");
double radius = double.Parse(Console.ReadLine());

double area = Math.PI * radius * radius;

Console.Write("The are of that circle is " + area + ".");



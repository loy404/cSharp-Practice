// 19. Ask the user to enter the side length of a square. Then show the area of the square.

Console.Write("Enter the side length of square: ");
int side = int.Parse(Console.ReadLine());

int area = side * side;

Console.Write("The area of the square is: " + area + ".");

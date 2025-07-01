// 17. Ask for birth year, calculate current age, and display. 

Console.Write("Enter birth year: ");
int bYear = int.Parse(Console.ReadLine());

int currentYear = DateTime.Now.Year;
int age = currentYear - bYear;

Console.Write("You are " + age + " years old now.");




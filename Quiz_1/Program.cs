//Ex.1
// Code >> Complier >> CIL >> CLR >> Machine Code

//Ex.2

double x, y;

Console.WriteLine("Enter two numbers to calculate: ");

bool result1 = double.TryParse(Console.ReadLine(), out x);
bool result2 = double.TryParse(Console.ReadLine(), out y);

if (result1 && result2)
{
    Console.WriteLine("Sum: " + (x + y));
    Console.WriteLine("Substract: " + (x - y));
    Console.WriteLine("Multiply: " + (x * y));
}

else
{
    Console.WriteLine("Not Numbers");
}


//Ex.3

Console.WriteLine("Enter rectangle sides: ");

result1 = double.TryParse(Console.ReadLine(), out x);
result2 = double.TryParse(Console.ReadLine(), out y);

if (result1 && result2)
{
    Console.WriteLine("Area: " + (x * y) + " Perimeter: " + (2 * x + 2 * y));
}


//Ex.4

int[] numbers = new int[3];

Console.WriteLine("Enter 3 numbers to sort");

numbers[0] = int.Parse(Console.ReadLine());
numbers[1] = int.Parse(Console.ReadLine());
numbers[2] = int.Parse(Console.ReadLine());

Array.Sort(numbers);
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(numbers[i]);
}


//Ex.5

Console.WriteLine("Enter 3 digit number");

int threenum = int.Parse(Console.ReadLine());

Console.WriteLine(threenum/100);
Console.WriteLine((threenum/10)%10);
Console.WriteLine(threenum%10);


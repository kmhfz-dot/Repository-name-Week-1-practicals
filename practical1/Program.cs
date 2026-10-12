Console.WriteLine("What is your name?");
string name = Console.ReadLine(); 
Console.WriteLine($"Hello {name}");
Console.WriteLine("What is your age?");
int age = Convert.ToInt32(Console.ReadLine());
int futureAge = age + 5;
Console.WriteLine($"{name}, you will be {futureAge} years old in 5 years.");
if (age < 0 || age > 110)
{
    Console.WriteLine("Invalid age");
}
else if (age < 13)
{
    Console.WriteLine("Child");
}
else if (age >= 13 && age <= 19)
{
    Console.WriteLine("Teenager");
}
else
{
    Console.WriteLine("Adult");
}
Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    Console.WriteLine("Positive");
}
else if (number < 0)
{
    Console.WriteLine("Negative");
}
else
{
    Console.WriteLine("Zero");
}
Console.WriteLine("Enter a year:");
int year = Convert.ToInt32(Console.ReadLine());
if (year < 0)
{
    Console.WriteLine("Invalid year");
}
else if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
{
    Console.WriteLine("Leap year");
}
else
{
    Console.WriteLine("Not a leap year");
}
Console.WriteLine("Enter a number to check if it is even or odd:");
int evenOddNumber = Convert.ToInt32(Console.ReadLine());
if (evenOddNumber % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}
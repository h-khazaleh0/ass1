using System;

// Assignment 1: Day Name
Console.WriteLine("Assignment 1: Day Name ");
Console.Write("Enter a number for the day (1 to 7): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
string dayName;

switch (dayNumber)
{
    case 1:
        dayName = "Sunday";
        Console.WriteLine($"The day is: {dayName}");
        break;
    case 2:
        dayName = "Monday";
        Console.WriteLine($"The day is: {dayName}");
        break;
    case 3:
        dayName = "Tuesday";
        Console.WriteLine($"The day is: {dayName}");
        break;
    case 4:
        dayName = "Wednesday";
        Console.WriteLine($"The day is: {dayName}");
        break;
    case 5:
        dayName = "Thursday";
        Console.WriteLine($"The day is: {dayName}");
        break;
    case 6:
        dayName = "Friday";
        Console.WriteLine($"The day is: {dayName}");
        break;
    case 7:
        dayName = "Saturday";
        Console.WriteLine($"The day is: {dayName}");
        break;
    default:
        Console.WriteLine("Invalid input");
        break;
}


//***************************************************************************************************
//Assignment 2: Days in a Month
Console.WriteLine("Assignment 2: Days in a Month");
Console.Write("Enter a number for the month (1 to 12): ");
int monthNumber = Convert.ToInt32(Console.ReadLine());
int days;
switch (monthNumber)
{
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        days = 31;
        Console.WriteLine($"Month number {monthNumber} has {days} days.");
        break;

    case 2:
        days = 28;
        Console.WriteLine($"Month number {monthNumber} has {days} days.");
        break;

    case 4:
    case 6:
    case 9:
    case 11:
        days = 30;
        Console.WriteLine($"Month number {monthNumber} has {days} days.");
        break;

    default:
        Console.WriteLine("Invalid input");
        break;
 }

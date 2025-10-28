using System;

// Assignment 1: Day Name
Console.WriteLine("Assignment 1: Day Name ");
Console.Write("Enter a number for the day (1 to 7): ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber >= 1 && dayNumber <= 7)
{
    string dayName;

    switch (dayNumber)
    {
        case 1:
            dayName = "Sunday";
            break;
        case 2:
            dayName = "Monday";
            break;
        case 3:
            dayName = "Tuesday";
            break;
        case 4:
            dayName = "Wednesday";
            break;
        case 5:
            dayName = "Thursday";
            break;
        case 6:
            dayName = "Friday";
            break;
        case 7:
            dayName = "Saturday";
            break;
        default:
            dayName = "Unexpected error.";
            break;
    }
    Console.WriteLine($"The day is: {dayName}");
}
else
{
    Console.WriteLine("Invalid input");
}
//***************************************************************************************************
//Assignment 2: Days in a Month
Console.WriteLine("Assignment 2: Days in a Month");
Console.Write("Enter a number for the month (1 to 12): ");
int monthNumber = Convert.ToInt32(Console.ReadLine());

if (monthNumber >= 1 && monthNumber <= 12)
{
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
            break;

        case 2:
            days = 28;
            break;

        case 4:
        case 6:
        case 9:
        case 11:
            days = 30;
            break;

        default:
            days = -1;
            break;
    }

    Console.WriteLine($"Month number {monthNumber} has {days} days.");
}
else
{
    Console.WriteLine("Invalid input");
}
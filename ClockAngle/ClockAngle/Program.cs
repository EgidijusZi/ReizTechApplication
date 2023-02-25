
int hour, minute;

Console.WriteLine("Enter the hour between 0 and 24:");

while (!int.TryParse(Console.ReadLine(), out hour) || hour < 0 || hour > 24)
{
    Console.WriteLine("Invalid input. Please enter a hour value between 0 and 24.");
}

Console.WriteLine("Enter the minute between 0 and 59:");

while (!int.TryParse(Console.ReadLine(), out minute) || minute < 0 || minute > 60)
{
    Console.WriteLine("Invalid input. Please enter a minute value between 0 and 60.");
}

double hourArrowAngle = (hour % 12 + minute / 60.0) * 30;
double minuteArrowAngle = minute * 6;
double angleDifference = Math.Abs(hourArrowAngle - minuteArrowAngle);

if (angleDifference > 180)
{
    angleDifference = 360 - angleDifference;
}

Console.WriteLine($"The lesser angle between the hour and minute arrows is {angleDifference:F2} degrees.");

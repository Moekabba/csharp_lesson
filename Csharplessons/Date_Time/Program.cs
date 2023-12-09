
// Date and Time Type
// Respresent an instant in time, ranges from year 1 - 9999
// The unit is ticks based on 100 nanosecond
//Supports different calender, time zones, transformations between different date and times

using System.Globalization;

DateTime dateOfTime = new DateTime(1997, 2, 3); // object of Date time

//dateOfTime.AddDays(1);
Console.WriteLine(dateOfTime.DayOfWeek); // make this dynamic to collect use input

// computed values 
DateTime today = DateTime.Now;
DateTime utcNow = DateTime.UtcNow;
Console.WriteLine($"{today}, {utcNow}");

// DateTime parsing 
DateTime localDate = DateTime.Parse("02/03/1997");
DateTime gDate = DateTime.Parse("03.02/1997", new CultureInfo("en-GA"));
Console.WriteLine($"local date: {localDate}, Germany : {gDate}");
// See https://aka.ms/new-console-template for more information

//Empty  DateTime
using System;
using System.Globalization;

DateTime date = new DateTime();
////Create a DateTime  from date and  time
//var dateOfBirth = new DateTime(1990,4,21);
//Console.WriteLine($" My DOB is :  {dateOfBirth}");

//var exactDateAndTimeOfBirth = new DateTime(1990,4,21 ,20,08,09,DateTimeKind.Local);
//Console.WriteLine($" My DOB is :  {exactDateAndTimeOfBirth}");
//Console.WriteLine($" Day of Week :{dateOfBirth.DayOfWeek}");
//Console.WriteLine($" Day of Year :{dateOfBirth.DayOfYear}");
//Console.WriteLine($" Time of Day :{exactDateAndTimeOfBirth.TimeOfDay}");
//Console.WriteLine($" Tick :{exactDateAndTimeOfBirth.Ticks}");
//Console.WriteLine($" Kind :{exactDateAndTimeOfBirth.Kind}");

//Create a DateTime  from current  timestamp
DateTime now  = DateTime.Now;
//Console.WriteLine("The   Time is Now : " + now);
//// Create DateTime from a String
//Console.WriteLine("What is  your DOB (MM/dd/yyyy):");
//string dob = Console.ReadLine();
// var userDob = DateTime.Parse(dob);
//Console.WriteLine($" Day of Week :{userDob.DayOfWeek}");
//Console.WriteLine($" Day of Year :{userDob.DayOfYear}");
//Console.WriteLine($" Time of Day :{userDob.TimeOfDay}");
//Console.WriteLine($" Tick :{userDob.Ticks}");
//Console.WriteLine($" Kind :{userDob.Kind}");

//// Change  Format   DateTime
//Console.WriteLine($"Formatted Date: {userDob.ToString("dd/MM/yy")}");
//Console.WriteLine($"Formatted Date: {userDob.ToString("MMM  dd, yyyy")}");
//Console.WriteLine($"Formatted Date: {userDob.ToString("dd/MM/yy")}");
//Console.WriteLine($"Formatted Date: {userDob:dddd, dd MMMM ,yyyy)}");
////Add additional  Time
//Console.WriteLine("One  hour  from now is: " + now.AddHours(1));
//Console.WriteLine("One  Day  from now is: " + now.AddDays(1));
//Console.WriteLine("One  Day   ago from is: " + now.AddDays(-1));
//Console.WriteLine("Sixty Second  from now is: " + now.AddSeconds(60));


Console.WriteLine("***** Start DateTime Manipulation******");
//UTC - Coordinated Universal Time
//var utcNow = DateTime.UtcNow;

//Console.WriteLine($"Now  Date Time : {now}");
//Console.WriteLine($"Now  Date Time : {utcNow}");
////DateTimeOFFSet and TimeZone info 
//var timezone = TimeZoneInfo.Local.GetUtcOffset(utcNow);
//Console.WriteLine($" user Time Zone: {timezone}");

//var DateTimeOffset = new DateTimeOffset(now,timezone);
//Console.WriteLine($" user Time Zone with utc Offset: {DateTimeOffset}");
//Console.WriteLine($" UTC Time  of Action : {DateTimeOffset.UtcDateTime}");

//var USATimezone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Daylight Time ");
//var USADateTime = TimeZoneInfo.ConvertTimeFromUtc(DateTimeOffset.UtcDateTime, USATimezone);
//Console.WriteLine($"Action  was  completed  in  India  at : {USADateTime}");
Console.WriteLine("*****  End DateTime Manipulation******");
Console.WriteLine("*****  Start Date Only  and Time Only Manipulation ******");
//DateOnly
var dateOnly = new DateOnly(1990, 4, 21);
var nextDay = dateOnly.AddDays(1);
var previousDay = dateOnly.AddDays(-1);
var decadeLater = dateOnly.AddYears(10);
var lastMonth= dateOnly.AddMonths(-1);

Console.WriteLine($"The Date : {dateOnly}");
Console.WriteLine($"The Next  Day : {nextDay}");
Console.WriteLine($"The Prevoius Day : {previousDay}");
Console.WriteLine($"The Decade  later : {decadeLater}");
Console.WriteLine($"The Last Month: {lastMonth}");

//var DateOnlyFromDateTime = DateOnly.FromDateTime(now);
//Console.WriteLine($"Date Only  From DateTime: {DateOnlyFromDateTime}");

//Console.WriteLine($"What is  your DOB (dd MMM yyyy):");
//string dobDateOnly = Console.ReadLine();
//var theDateonly = DateOnly.ParseExact(dobDateOnly, "dd MMM yyyy",CultureInfo.InvariantCulture);
//Console.WriteLine($" The Date Only: {theDateonly}");
// TimeOnly    
var timeNow = TimeOnly.FromDateTime( now);
Console.WriteLine($"It is now {timeNow}");
Console.WriteLine($"It is now {timeNow: hh:mm tt}");

//Date Comparsion
var date1 = new DateTime(1985,11,23);
var date2 = new DateTime(1965, 1, 20);

Console.WriteLine($"Is '{nameof(date1)}' equal? {date1==date2}");
Console.WriteLine($"Is '{nameof(date1)}' equal? {date1.Equals(date2)}");
Console.WriteLine($"Is {date2} after ? {date2 > date1}");
Console.WriteLine($"Is {date2} before ? {date2 < date1}");


Console.WriteLine("*****  End Date Only  Manipulation******");

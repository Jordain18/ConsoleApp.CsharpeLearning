// Declare Variables
using System.Xml.Linq;

string? myFirstName = string.Empty;
string? myLastName = string.Empty;
int myAge ;
int retirementAge = 65;
decimal salary ;
char gender = char.MinValue;
bool working=true;

//Prompt  user for input 
Console.Write("Please  insert your first name ");
myFirstName = Console.ReadLine();
Console.Write("Please  insert your last name ");
myLastName = Console.ReadLine();
Console.Write("Please  insert your age ");
myAge = Convert.ToInt32 (Console.ReadLine());
Console.Write("Please  insert your salary ");
salary = Convert.ToDecimal(Console.ReadLine());

Console.Write("Please  insert your gender( M or F) ");
gender = Convert.ToChar(Console.ReadLine());
Console.Write("Are you employed ? (true or false)");
working = Convert.ToBoolean(Console.ReadLine());
//Process the Data
int workingYearsRemaining = retirementAge - myAge;

//Output the results to the user
Console.WriteLine($"Full name is :{myFirstName +" "+ myLastName}");
Console.WriteLine($"Age : {myAge}");

Console.WriteLine($"Your is  salary : {salary}");
Console.WriteLine($"You are  is gender: {gender}");
Console.WriteLine($"  Are you employed ? : {working}");
Console.WriteLine($"Working years Remaining  : {workingYearsRemaining}");


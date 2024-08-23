// Declare Variables
using System.Xml.Linq;

string myFirstName = string.Empty;
string myLastName = string.Empty;
int myAge =0;
int retirementAge = 65;

//Prompt  user for input 
Console.WriteLine("Please  insert your first name ");
myFirstName = Console.ReadLine();
Console.WriteLine("Please  insert your last name ");
myLastName = Console.ReadLine();
Console.WriteLine("Please  insert your age ");
myAge = Convert.ToInt32 (Console.ReadLine());

//Process the Data
int workingYearsRemaining = retirementAge - myAge;

//Output the results to the user
Console.WriteLine($"Full name is :{myFirstName +" "+ myLastName}");
Console.WriteLine($"Age : {myAge}");
Console.WriteLine($"Working years Remaining  : {workingYearsRemaining}");

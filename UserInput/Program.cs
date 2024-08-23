// Declare Variables
string myName = string.Empty;
int myAge =0;
int retirementAge = 65;

//Prompt  user for input 
Console.WriteLine("Please  insert your name ");
myName = Console.ReadLine();
Console.WriteLine("Please  insert your age ");
myAge = Convert.ToInt32 (Console.ReadLine());

//Process the Data
int workingYearsRemaining = retirementAge - myAge;

//Output the results to the user
Console.WriteLine($"Full name is :{myName}");
Console.WriteLine($"Age : {myAge}");
Console.WriteLine($"Working years Remaining  : {workingYearsRemaining}");

// Declare Variables
using System.Globalization;
using System.Xml.Linq;

string? myFirstName = string.Empty;
string? myLastName = string.Empty;
int myAge ;
DateOnly dob = new DateOnly();

 const int retirementAge = 65;

decimal salary ;
char gender = char.MinValue;
bool working=true;
try
{
    //Prompt  user for input 
    Console.Write("Please  insert your first name ");
    myFirstName = Console.ReadLine();
    Console.Write("Please  insert your last name ");
    myLastName = Console.ReadLine();
    Console.Write("Please  insert your date of birth (dd/mm/yyyy): ");
    dob = DateOnly.ParseExact(Console.ReadLine(), "dd/mm/yyyy", CultureInfo.InvariantCulture);
    myAge = DateTime.Now.Year - dob.Year;
    Console.Write("Please  insert your salary ");
    salary = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Please  insert your gender( M or F) ");
    gender = Convert.ToChar(Console.ReadLine());
    Console.Write("Are you employed ? (true or false)");
    working = Convert.ToBoolean(Console.ReadLine());
    //Process the Data
    int workingYearsRemaining = retirementAge - myAge;
    var estimatedRetirementDate = DateTime.Now.AddYears(workingYearsRemaining);
    Console.WriteLine($"Full name is :{myFirstName + " " + myLastName}");
    Console.WriteLine($"Age : {myAge}");

    Console.WriteLine($"Your is  salary : {salary.ToString("C")}");
    Console.WriteLine($"You are  is gender: {gender}");
    Console.WriteLine($"  Are you employed ? : {working}");
    Console.WriteLine($"Working years Remaining  : {workingYearsRemaining}");
    Console.WriteLine($"Estimated Retirement year  : {estimatedRetirementDate.Year}");
}
catch (Exception)
{

	Console.WriteLine(" Invalid Input");
}

//Output the results to the user



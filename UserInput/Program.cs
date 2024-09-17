// Declare Variables
using System.Globalization;
using System.Xml.Linq;
char choice =char.MinValue;
string? myFirstName = string.Empty;
string? myLastName = string.Empty;
int myAge ;
DateOnly dob = new DateOnly();
decimal salary ;
char gender = char.MinValue;
bool working=true;
List<Person> persons = new List<Person>();

while (choice != 'E')
{  //Prompt  user for input 
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

    Person person = new(dob)
    {
        FirstName = myFirstName,
        LastName = myLastName,

        Gender = gender,
        Salary = salary,
        IsWorking = working
    };
    //Process the Data

    persons.Add(person);
    //persons.Add(new Person(dob)

    //{
    //    FirstName = myFirstName,
    //    LastName = myLastName,

    //    Gender = gender,
    //    Salary = salary,
    //    IsWorking = working
    //}
    //    );


    Console.WriteLine(" C - Continue | E- Exit");

    choice = Convert.ToChar(Console.ReadLine());
}
foreach (var person in persons)
{
    Console.WriteLine();
    Console.WriteLine($"Full name is :{person.ToString()}");
    Console.WriteLine($"Age : {person.GetAge()}");

    Console.WriteLine($"Your is  salary : {person.Salary.ToString("C")}");
    Console.WriteLine($"You are  is gender: {person.Gender}");
    Console.WriteLine($"  Are you employed ? : {person.IsWorking}");
    Console.WriteLine($"Working years Remaining  : {person.GetNumberOfWorkingYearsRemaining()}");
    Console.WriteLine($"Estimated Retirement year  : {person.GetEstimatedRetirementDate()}");


}



// Declare Variables
//Output the results to the user

public class Person
{
    public Person(DateOnly dob)
    {
        _myAge = DateTime.Now.Year- dob.Year;
        DateOfBirth = dob;
    }

    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    
    public  DateOnly DateOfBirth { get; init; }
    public  decimal Salary { get; set; } 
    public  char Gender { get; set; }
    public  bool IsWorking { get; set; }

    private readonly int _myAge;

    public int GetNumberOfWorkingYearsRemaining()
    {
        return Constants.RetirementAge - _myAge;
    }
     public int GetAge()
    {
        return _myAge;
    }
    public DateOnly GetEstimatedRetirementDate()
    {
        return  DateOnly.FromDateTime(DateTime.Now.AddYears(GetNumberOfWorkingYearsRemaining())) ;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}

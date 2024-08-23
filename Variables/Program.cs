// See https://aka.ms/new-console-template for more information


//Different datatypes
/*
text -string
integers-int
decimal-double, float,decimal
logical- bool

 */
//Defining variable and assigning  a value.
string name = "Jordain Campbell";
//Printing  a variable  by itself, or  with some string.
 Console.WriteLine(name);
Console.WriteLine("I am " + name);// String  concatenation
Console.WriteLine($"They call me {name}" ); // String interpolation
Console.WriteLine("I was  given  the name {0} ",name);//formatted String
//Defining  more varaibles along  with doing calculation
int age = 25;

Console.WriteLine(age);
int retirementYearsLeft = 40;
int retirementAge = age + retirementYearsLeft;
//Invalid assignment of a Value.
// string retirementAge = age + retirementYearsLeft;
Console.WriteLine("My age is : " + age);

bool isRetired = false;

Console.WriteLine("Am I retired? " + isRetired);
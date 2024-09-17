// See https://aka.ms/new-console-template for more information
using Classes.Classes.Person;
using Classes.Classes.Shape;

Console.WriteLine("****** - Classes and Objects- ******");

//Define an object of type Person 
//Person person ; // be null by default
Person baby = new Person();
baby.LastName = "Campbell";
baby.FirstName = "Jordain";
baby.DateOfBirth = new DateOnly(1998, 10, 21);
 

baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();
var taxNumber =baby.GetTaxNumber();
Console.WriteLine(taxNumber);

var person1 = new Person("Developer","One",new DateOnly(2000,10,31));

person1.PrintFullName();
person1.PrintInitials();

var person2 = new Person("Great", "Jordon","345678901");

person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();
 var person2IDNumber=person2.GetIDNumber();
Console.WriteLine(person2IDNumber);

var teacher = new Teacher();
teacher.LastName = "Gordon";
teacher.FirstName = "Sashene";
teacher.DateOfBirth = new DateOnly(1998, 10, 21);
teacher.PrintFullName();
teacher.PrintInitials();

var teachertaxNumber = teacher.GetTaxNumber();
Console.WriteLine(teachertaxNumber);
teacher.GenerateTaxNumber();


var teacherIdNumber = teacher.GetIDNumber();
Console.WriteLine(teacherIdNumber);
teacher.GenerateTeacherIDNumber();

Student student = new();
student.LastName = "Campbell";
student.FirstName = "Jordain";
student.DateOfBirth = new DateOnly(1998, 10, 21);
student.PrintFullName();
student.PrintInitials();
student .GenerateTaxNumber();
var studnetIdnumber = student.GetIDNumber();
student .GenerateStudentIDNumber();
Console.WriteLine(studnetIdnumber);

//Polygon polygon = new Polygon(); // complier error
Rectangle rectangle = new(10, 20);
rectangle.GetShapeName();
var rectangleArea = rectangle.Area();
Console.WriteLine($" Area of Rectangle is : {rectangleArea}");
Square square = new(45);
var squareArea = square.Area();
Console.WriteLine($" Area of Square is : {squareArea}");

Cuboid cuboid = new(1, 5, 7);
var cuboidArea = cuboid.Area();
var cuboidVolume = cuboid.Volume();
var cuboidPerimeter = cuboid.Perimeter();

Console.WriteLine($"Cuboid area is: {cuboidArea}");
Console.WriteLine($"Cuboid Perimeter is: {cuboidPerimeter}");
Console.WriteLine($"Cuboid Volume is: {cuboidVolume}");


Sphere  sphere = new( 7);

var sphereVolume= sphere.Volume();
var sphereCircumsference= sphere.Circumference();


Console.WriteLine($"{nameof (Sphere)}  Circumference is: {sphereCircumsference}");
Console.WriteLine($"{nameof(Sphere)}  Volume is: {sphereVolume}");


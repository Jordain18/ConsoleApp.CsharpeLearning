// See https://aka.ms/new-console-template for more information
// For Loops
// How Print the Loop 10 times
//0 123456789 - this is way loop will increase by adding one
for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello, World! -{i}");
}
Console.WriteLine("Loop Completed !");
//// Ask  User  how many  times  they  wish to  print hello   world   and print  accordingly

Console.WriteLine("Please  ask how many times you want print 'Hello,World! in a loop'");
int userInput = Convert.ToInt32(Console.ReadLine());
for (int x = 0; x < userInput; x++)
{
    Console.WriteLine($"Hello, World! - {x}");
}
Console.WriteLine("Loop Completed !");
//   Add  three numbers five times and make it  increment by 2 each time ; then print outputs.

Console.WriteLine("Please enter   first Number");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter   second Number");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter   third Number");
int n3 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Please  ask how many times you want print 'Hello,World! in a loop'");
int Input = Convert.ToInt32(Console.ReadLine());
int sum;
for (int x = 0; x < Input; x+=2)
{
    sum = n1 + n2 + n3;
    Console.WriteLine($"The Sum :{sum}  {x} ");
}

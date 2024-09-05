// See https://aka.ms/new-console-template for more information
// Write  a programme  take a user's age  as input  and print it  to the screen.
//Display an error message  if an invalid  input is received.
try
{
    Console.Write(" Please insert your age : ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Your age is : {age}");
}
catch (Exception)
{

    Console.WriteLine("Your age value is incorrect, please try again.");
    //throw;
}
finally
{
    Console.WriteLine("****** Thank You for using This Programme. Have a NIce Day !******");
}
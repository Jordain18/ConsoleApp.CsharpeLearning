// See https://aka.ms/new-console-template for more information
// Days of Week IF Statement Challenges

Console.WriteLine("*********** - Welcome  to Days of Week IF Challenges ! - **************");


Console.WriteLine("s. Sunday");
Console.WriteLine("m. Monday");
Console.WriteLine("t. Tuesday");
Console.WriteLine("w.  WednesdaY");
Console.WriteLine("h.  Thursday ");
Console.WriteLine("f.  Friday ");
Console.WriteLine("a.  Saturday ");
Console.WriteLine("Please select  a day .");
char options = Convert.ToChar(Console.ReadLine());

if(options == 's')
{
    Console.WriteLine("Today is Sunday ");
}
else if(options == 'm')
{
    Console.WriteLine("Today is Monday ");
}
else if (options == 't')
{
    Console.WriteLine("Today is Tuesday ");
}
else if (options == 'w')
{
    Console.WriteLine("Today is Wednesday ");
    Console.WriteLine("Hump Day ! ");
}
else if (options == 'h')
{
    Console.WriteLine("Today is Thursday ");
}
else if (options == 'f')
{
    Console.WriteLine("Today is Friday ");
    Console.WriteLine("TGIF");
}
else if (options == 'a')
{
    Console.WriteLine("Today is Saturday ");
    Console.WriteLine(" Today is Beach Day !");    
}


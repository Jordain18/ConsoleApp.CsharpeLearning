// See https://aka.ms/new-console-template for more information
// While Loop 
using System.Diagnostics.CodeAnalysis;

//int counter = 0;
//while (counter < 10)
//{
//    Console.WriteLine($"Hello, World! - {counter}");
//    counter+=2;
//}
// Ask the  user  for a number and  find  the total  for each  number  that is  entered. Print  final  sum when  the  enters -1 to exit;
Console.WriteLine("**************** Simple Nested If While Loop ****************");
int number = -1 ;
int sum = 0;
while ( number != -1)
{
    Console.WriteLine(" Please enter a number (exit when it reach -1 ");
    number= Convert.ToInt32(Console.ReadLine());
    //nested if statment 
    if (number == -1)
    {

        Console.WriteLine($" The Final Sum of Loop : {sum}");
    }
    else
    {
        sum += number;

    }
}
Console.WriteLine("**************** Simple Nested If While Loop ****************");

Console.WriteLine("**************** Simple Do... While Loop ****************");
// Do While Loop - post Condition 
sum = 0;
number = -1;
do
{
    Console.WriteLine(" Please enter a number (exit when it reach -1 ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == -1)
    {

        Console.WriteLine($" The Final Sum of Loop : {sum}");
    }
    else
    {
        sum += number;

    }


} while (number != -1);



Console.WriteLine("**************** Simple Do... While Loop ****************");

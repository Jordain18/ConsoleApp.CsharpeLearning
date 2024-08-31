// See https://aka.ms/new-console-template for more information
//Welcome  Message 
using System.Numerics;

Console.WriteLine("*********** - Welcome  to the Sample  calculator ! - **************");

Console.WriteLine("Please selct an operation");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5.  Modulus");
int choice = Convert.ToInt32(Console.ReadLine());
//Prompt  for  user input 
Console.WriteLine(" Please  enter  the  first  number:");

int number1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine(" Please  enter  the  second  number:");
int number2 = Convert.ToInt32(Console.ReadLine());

//Show calculator option /Show menu

//Decide which  operation is needed  based  on selected option
//Using If statement 
//if (choice == 1)
//{
//    int sum = number1 + number2;
//    Console.WriteLine($" The sum is: {sum}");
//}
//else if(choice == 2)
//{
//    int difference = number1 - number2;
//    Console.WriteLine($" The difference is: {difference}");
//}
//else if(choice == 3)
//{
//    int product = number1 * number2;
//    Console.WriteLine($"The Product is: {product} ");
//}
//else if(choice == 4)
//{
//    int quotient = number1 / number2;
//    Console.WriteLine($"The Quotient is: {quotient} ");
//}
//else if(choice == 5)
//{
//    int modulus = number1 % number2;

//    Console.WriteLine($"The Modulus is: {modulus} ");
//}
//else
//{
//    Console.WriteLine("Invalid Input! Have a Nice day.");
//}

// Using switch case
int answer =0;
switch (choice)
{
    case 1:
        answer = number1 + number2;
        //int sum = number1 + number2;
        // Console.WriteLine($" The sum is: {sum}");
        break;

        case 2:
        answer = number1 - number2;
        //int difference = number1 - number2;
        //Console.WriteLine($" The difference is: {difference}");
        break;
    case 3:
        answer = number1 * number2;
        //int product = number1 * number2;
        //Console.WriteLine($"The Product is: {product} ");
        break;
        case 4:
        answer = number1 / number2;
        //int quotient = number1 / number2;
        //Console.WriteLine($"The Quotient is: {quotient} ");
        break;
    case 5:
        answer = number1 % number2;
        //int modulus = number1 % number2;

        //Console.WriteLine($"The Modulus is: {modulus} ");
        break;
    default:
        Console.WriteLine("Invalid Input! Have a Nice day.");
        break;
}
//print output
Console.WriteLine($"The result is : {answer}");
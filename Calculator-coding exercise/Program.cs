﻿// See https://aka.ms/new-console-template for more information
//Welcome  Message 
using System;
using System.Numerics;

int choice = 0;
int number1 = 0;
int number2 = 0;
while(choice != -1)
    
{
    try
    {
        PrintMenu();
        
            choice = Convert.ToInt32(Console.ReadLine());
      
        
            

        if (choice == -1)
        {
            break;
        }

      
            Console.WriteLine(" Please  enter  the  first  number:");

            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Please  enter  the  second  number:");
            number2 = Convert.ToInt32(Console.ReadLine());

        // Using switch case
        int answer = 0;
        switch (choice)
        {
            case 1:
                answer = AdditionOperation(number1 ,number2);
                
                break;

            case 2:

                answer = SubtractionOperation(number1, number2);
                //int difference = number1 - number2;
                //Console.WriteLine($" The difference is: {difference}");
                break;
            case 3:
                answer = MultiplicationOperation(number1,number2);
                //int product = number1 * number2;
                //Console.WriteLine($"The Product is: {product} ");
                break;
            case 4:

                answer = DivisionOperation(number1,number2); 
                
                
              
                //int quotient = number1 / number2;
                //Console.WriteLine($"The Quotient is: {quotient} ");
                break;
            case 5:
                answer = ModulusOperation(number1,number2); 
                //int modulus = number1 % number2;

                //Console.WriteLine($"The Modulus is: {modulus} ");
                break;
            case 6:
                answer= Fibonnaci(number1,number2);
             

                break;
            default:
                throw new Exception("Invalid Menu Item Selected");

        }
        Console.WriteLine($"The result is : {answer}");

        Console.WriteLine("Press enter to continue");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine();
        Console.WriteLine();

    }
    catch (DivideByZeroException)
    {

        Console.WriteLine(" We cannot divided by zero");
       
        
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        
    }
    finally
    {
        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
        Console.Clear();

    }




}

int Fibonnaci(int number1, int number2)
{
    var answer = 0;
    for (int a = number1; a <= number2; a++)
    {
        answer += a;
    }
    return answer;
}

Console.WriteLine("**** Thank you for  using the calculator *****");

// Methods Go here
void PrintMenu()
{
    Console.Clear();
    Console.WriteLine("*********** - Welcome  to the Sample  calculator ! - **************");

    Console.WriteLine("Please selct an operation - ( -1 to exit )");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5.  Modulus");
    Console.WriteLine("6. Fibonacci sequence");
}
int AdditionOperation(int number1, int number2)
{
    return number1 + number2;

}

int SubtractionOperation(int number1, int number2)
{
    return number1 - number2;
}
int MultiplicationOperation(int number1, int number2)
{
    return number1 * number2;
}

int DivisionOperation(int number1, int number2)
{
    return number1 / number2;
}
int ModulusOperation(int number1, int number2)
{
    return number1 % number2;
}
//Prompt  for  user input 

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


//print output

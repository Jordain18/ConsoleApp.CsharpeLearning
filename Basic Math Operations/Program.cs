// See https://aka.ms/new-console-template for more information

//Prompt User For  2 Numbers .
Console.Write("Please enter number 1: "); 
int num1 = Convert.ToInt32 (Console.ReadLine());


Console.Write("Please enter number 2: ");
int  num2 = Convert.ToInt32(Console.ReadLine());

//Process/ Operations
// Adding Numbers
/*
  Basic Math  Operations 
 int sum = num1 + num2;
//multiply
int product = num1 * num2;
//divide
int quotient = num2 / num1;

//subtraction
int difference = num2 - num1;

//Modulus 
int mod =num2%num1;

//Output
Console.WriteLine($"The Sum is : {sum}");
Console.WriteLine($"The Product is : {product}");
Console.WriteLine($"The Quotient is : {quotient}");
Console.WriteLine($"The Difference is : {difference}");
Console.WriteLine($"The   Modulus is : {mod}");
 */


/*
   Basic Logic Operation
 */

// Process 
 bool  isGreaterThan = num1 > num2;
bool isLessThan = num1 < num2;
 bool isEqual = num1 == num2;
 bool isNotEqual = num1 != num2;
 bool isGreaterThan_or_equalto = num1 >= num2;
 bool isLessThan_or_equalto =num1 <= num2;
// Output
Console.WriteLine("***************** Start Logic results *******************");
Console.WriteLine();
Console.WriteLine($" IS Greater Than: {isGreaterThan}");
Console.WriteLine($" IS Less Than: {isLessThan}");
Console.WriteLine($" IS Equal : {isEqual}");
Console.WriteLine($" IS Greater than or equal: {isGreaterThan_or_equalto}");
Console.WriteLine($" IS Less Than or equal : {isGreaterThan_or_equalto}");
Console.WriteLine();
Console.WriteLine("*****************  End Logic results *******************");

/*
 
Assignment Operations and Operators
 */
//int random_value = 5;

//int increase_value = num1 + 5;

//Process
//num1 = num1 + 5;


Console.WriteLine("***************** Start Assignment results *******************");
Console.WriteLine();

num1 += 5;
Console.WriteLine($" New Number1 increase Five is : {num1}");
num1 -= 1;
Console.WriteLine($" New Number1 reduce One is : {num1}");
num1 /= 2;
Console.WriteLine($" New Number1 divide Two is : {num1}");
num1 *= 4;
Console.WriteLine($" New Number1 multiply Four is : {num1}");
num1 %= 2;
Console.WriteLine($"New Number1 modulus by 2 is : {num1}");

Console.WriteLine();
Console.WriteLine("*****************  End Assignment results *******************");
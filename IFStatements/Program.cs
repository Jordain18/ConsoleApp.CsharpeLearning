// See https://aka.ms/new-console-template for more information
//Prompt Input
Console.Write("Please enter a grade: ");
//Global Scoope
 int grade= Convert.ToInt32(Console.ReadLine());
// Set Condition and and Made Decisions
/*
 A+:90 -100
 A: 85-89
B+:80-84
B:75-79
B- : 70-74
C+: 65-69
C: 60-64
C-: 50-59
F: <50


 */

Console.WriteLine("******************** IF ELSE Statements********************************");
Console.WriteLine();

if (grade<0 || grade>100){

    Console.WriteLine(" Try Again!  Next Time.");
   
}
 else if (grade >=90 && grade<=100)
{
    Console.WriteLine("A+");
    
}
else if (grade>=85 && grade<=89)
{

    Console.WriteLine("A");
  
}
else if (grade>=80 && grade<= 84)
{
    Console.WriteLine("A-");
   

}
else if (grade>=75 && grade <= 79)
{
    Console.WriteLine("B+");
  
}
else if( grade>=70 && grade<= 75)
{
    Console.WriteLine("B-");
   
}
else if (grade >= 65 && grade <= 69)
{
    Console.WriteLine("C+");
    
}
else if (grade >= 60 && grade <= 64)
{
    Console.WriteLine("C");
 
}
else if (grade >= 50 && grade <= 59)
{
    Console.WriteLine("C-");
 
}
else if ( grade >= 0 && grade <50)
{
    Console.WriteLine("F");
    
}
Console.WriteLine();
Console.WriteLine("********************  End IF ELSE Statements********************************");


Console.WriteLine("********************  Start Tenary Operation ********************************");
Console.WriteLine();
string PassStatus = grade < 50 ? "Fail": "Pass";
Console.WriteLine($"Student  Status is: {PassStatus}"); 
int gradeAfterBonus =grade >= 0 && grade<= 100? grade+10:0;
Console.WriteLine($"Student  Status is: {gradeAfterBonus}");


Console.WriteLine();

Console.WriteLine("********************  End Tenary Operation ********************************");


/*
 Write  a program  to accept  an integer  as  the day  of  the  week and print
the appropiate message  as outlined below. Challenges use this in If Statements
 1- Sunday
 2- Monday
 3- Tuesday
 4- Wednesday (HUmp Day !)
 5- Thursday 
 6- Friday (TGIF)
 7- Saturday (Beach Day)
 
 */

Console.WriteLine("********************  Start Switch Case Operation ********************************");

Console.WriteLine("Please Insert a  number between 1 and 7");
int DaysOfTheWeek =Convert.ToInt32(Console.ReadLine());

switch (DaysOfTheWeek)
{
    case 1:
        Console.WriteLine("Sunday");    
   break;
    case 2:

        Console.WriteLine("Monday");
        break;
    case 3:
         Console.WriteLine("Tuesday");
        
        break;
                case 4:
                     Console.WriteLine("Wednesday");
                         Console.WriteLine("Hump Day !");
        
                break;
    case 5:
        Console.WriteLine("Thursday");
        break;
    case 6:

        Console.WriteLine("Friday ");
        Console.WriteLine("TGIF");
        break;
    case 7:
        Console.WriteLine("Saturday ");
        Console.WriteLine(" Beach Day");
        break;
    default:
        Console.WriteLine("This is not day of the week");
        break;
}

Console.WriteLine("********************  End Switch Case Operation ********************************");


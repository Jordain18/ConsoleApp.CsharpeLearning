// See https://aka.ms/new-console-template for more information
Console.WriteLine("******** Welcome To Arrays ******");
// Tell me how many students and grades to be entered 

Console.WriteLine("Please indicate  the number  of grades to be entered");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());
//Declare  Fixed  Size Array
int[] grades = new int[numberOfGrades];
string[]student = new string[numberOfGrades];
//int[] grades = new int[5];
// 5 spaces addresses/indexes -0,1,2,3,4
//If  n is  the size  of the array , then your array  has addresses  between 0 to n-1
//Add values to Fixed Size Array
//grades[0] = 45;
//grades[1] = 95;
//grades[2] = 85;
//grades[3] = 47;
//grades[4] = 50;
for (int i = 0; i < numberOfGrades; i++)
{
    Console.Write("Enter a student : ");
    student[i] = Console.ReadLine();
    Console.Write("Enter a grade : ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}
//////Print values in Fixed Sized Array
Console.WriteLine("Grades you enter are :");
for (int i = 0; i < numberOfGrades; i++)
{
    Console.WriteLine($"{student[i]},{grades[i]}");
   
}
//for (int i = 0; i < grades.Length; i++)
//{
//    Console.Write("Enter a grade : ");
//   grades[i] = Convert.ToInt32(Console.ReadLine());
//}

//////Print values in Fixed Sized Array
////Console.WriteLine("Grades you enter are :");
////for (int i = 0; i < grades.Length; i++)
////{
////    Console.WriteLine(grades[i]);
////}
////PRINT VALUES IN ARRAY - FOREACH
//foreach (int g in grades)
//{
//    Console.WriteLine(g);
//}

////Declare  Variable  Sized Array 
//string[] StudentNames =  { "Newton", "Tina", " Linda", "Kimmlee"};


////Add values  to Variable  Sized Array

//for (int i = 0; i < StudentNames.Length; i++)
//{
//    Console.WriteLine("The student  names  you have  entered are: ");
//    StudentNames[i] = Console.ReadLine();
//}


////Print values  in Variable Sized Array
//Console.WriteLine("The student  names  you have  entered are: ");
//for (int i = 0; i < StudentNames.Length; i++)
//{
//    Console.WriteLine(StudentNames[i]);
//}
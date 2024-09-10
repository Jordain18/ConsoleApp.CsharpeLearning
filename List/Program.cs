// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("******* - Lists - ******");
//Declare a List
List<int>grades =new List<int>();
List<string>students =new List<string>();
int grade = 0;
string name;
int gradeCount =0;
int @continue;
//var grades = new List<int>();
//List <int> grades= new();
//int grade = 0;

//Add values to list 
//grades.Add(85);
//Console.WriteLine(grades[0]);

//grades.Add(95);
//Console.WriteLine(grades[1]);
////grades.Add(98);
////grades.Add(80);

    do
{
    gradeCount += 1;
    Console.WriteLine("Enter -1  to stop enter in grades");
Console.Write("Enter a student : ");
name = Console.ReadLine();
    students.Add(name);
    Console.Write("Enter a grade : ");
      grade = Convert.ToInt32(Console.ReadLine());
    Console.Write("Do you wish to continue ? ( 1 = Yes | 2 = NO) ");
    @continue= Convert.ToInt32(Console.ReadLine());

    if (  grade!= -1)
{
    grades.Add(grade);
}
} while (@continue == 1) ;
//Print values in list-for 

Console.WriteLine("Grades you enter are :");
for (int i = 0; i < gradeCount; i++)
{
    Console.WriteLine($"{students[i]},{grades[i]}");

}
Console.WriteLine("Printing grades via  for-loops :");
//do
//{
//    Console.WriteLine("Enter -1  to stop enter in grades");
//    Console.Write("Enter a grade : ");
//    grade = Convert.ToInt32(Console.ReadLine());
//    if(grade != -1)
//    {
//        grades.Add(grade);
//    }
//} while(grade != -1);
//Print values in list-for 
//    Console.WriteLine("Printing grades via  for-loops :");
//for (int i = 0; i < grades.Count; i++)
//{

//    Console.WriteLine(grades[i]);
//}
//Print values in list - foreach
//Console.WriteLine("Printing grades via  for-each :");
//foreach (int g in grades)
//{
////    Console.WriteLine(g);
//}

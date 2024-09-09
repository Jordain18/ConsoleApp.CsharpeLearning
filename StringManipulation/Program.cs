// See https://aka.ms/new-console-template for more information
Console.WriteLine("****** -  String Manipulation - ********");
// Initialize  with a regular  string  literal .
string s0 = "This is a literal string";
String s1 = "This is a literal string";
Console.WriteLine($"{nameof(s0)}: {s0}");
Console.WriteLine($"{nameof(s1)} {s1}");

// declare  without  initializing . (possible null exception)
string s3;
//Console.WriteLine($"{nameof(s3)} {s3}"); // syntax error.  s3 needs  avalue before
//it can be used. 
// intialize to null
string? s4 = null;
Console.WriteLine($"{nameof(s4)} : {s4}");
// Initialize  as an empty string .
string? s5 = string.Empty;
string s6 = " ";
Console.WriteLine($"{nameof(s5)}:{s5}");
Console.WriteLine($"{nameof(s6)}:{s6}");
// Escape sequences and  characters
string sentence = "she said,\"I have your phone\"\r\n This is the next line";
Console.WriteLine($"{nameof(sentence)}:{sentence}");
// Verbatim  string literal
string oldPath = "C:\\program files\\programfolder\\";
string newpath = @"C:\program files\programfolder\";
Console.WriteLine($"{nameof(oldPath)}:{oldPath}");
Console.WriteLine($"{nameof(newpath)}:{newpath}");

// Use  const string  to prevent  modification  to a string
const string path= "C:\\program files\\programfolder\\";
//path="new value"; // Illegal operation against  a constant
s1 = "A new string";
Console.WriteLine($"{nameof(path)} :{path}");
Console.WriteLine($"{nameof(s1)} :{s1}");
// Raw  string  literals
string rawLiteral = """ she said,"I have your phone"  """;
string rawLiteral1 = """ 
she said,"I have your phone" 
 This a new line
 this is another new line
 Path =C:\program files\programfolder\
""";
Console.WriteLine($"{nameof(rawLiteral)} :{rawLiteral}");
Console.WriteLine($"{nameof(rawLiteral1)} :{rawLiteral1}");

// Review  concatentation  and interpolation
s0 = s0 + s1;
s0 += s1;

Console.WriteLine($"{nameof(s0)}:{s0}");

string newString = $"THis is inperpolation string {s0} {s1}";
string newString1 =  s1+ $"THis is inperpolation string {s0} {s1}";
string newString11 = String.Format("Literal string {0} {1}", s0, s1);
Console.WriteLine($"{nameof(newString)}:{newString}");
Console.WriteLine($"{nameof(newString1)}:{newString1}");
Console.WriteLine($"{nameof(newString11)}:{newString11}");

/* String Manipulation Method and properties -Sometimes  it just assessment*/
//Null or empty checks
//find the length of a string 
Console.WriteLine($"{nameof(s0)} has a length of {s0.Length}");
//Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");// wil cause null exception

Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}");
//if (string.IsNullOrEmpty(s4) == false)
if (!string.IsNullOrEmpty(s4))
    {
    Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}");
    
}
if (string.IsNullOrEmpty(s5) == false)
{
    Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
}
// SubString 
string subString = s0.Substring(5);
Console.WriteLine($"{nameof(subString)} : {subString}");
subString = s0.Substring(5, 5);
Console.WriteLine($"{nameof(subString)} : {subString}");
//Splitting strings
var splitString = s1.Split(' ');
for (int i = 0; i < splitString.Length; i++)
{
    Console.WriteLine(splitString[i]);
}
//Replace
string replacements = s1.Replace('s', 'V');
Console.WriteLine($"{nameof(replacements)} : {replacements}");
string replacements1 = s1.Replace("string", "thread");
Console.WriteLine($"{nameof(replacements1)} : {replacements1}");
// Convert  to string
string salary = 3500000.05.ToString();
int value = 564839;
string strValue = value.ToString();
bool chosen = true;
chosen.ToString();
//Change Formatting 
// for  further  reference : https://learn.mircosoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings#standard-format-specifiers
Console.WriteLine($"{nameof(salary)} : {salary:C}");
Console.WriteLine(nameof(salary)+ ":" + value.ToString("C"));



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double responseRate;
double unansweredRate;

responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;

unansweredRate = Q1Results.NumberSurveyed - Q1Results.NumberResponded;

Console.WriteLine($" Response Rate is {responseRate}; Unanswered Rate is:  {unansweredRate}");


Console.WriteLine("Provide Input: M/F/X"); 
var input = Console.ReadLine();

string gender = input switch
{
    "M" => "Male",
    "F" => "Female",
    "X" => "Other",
    _ => "Not specified"
}; 
Console.WriteLine($"Provided Gender is: {gender}");

Console.WriteLine("Provide Year: YYYY"); 

var yearInput = Console.ReadLine();

Console.WriteLine(Convert.ToInt32(yearInput) switch
{
    var year when year < 1800 => "before 18th Century",
    var year when year > 1801 && year < 1900 => "19th Century",
    var year when year > 1901 && year < 2000 => "20th Century",
    var year when year > 2001 && year < 2100 => "21st Century",
    _ => "Future"
}) ;

Console.ReadKey();

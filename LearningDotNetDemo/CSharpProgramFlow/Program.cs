// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

double responseRate;
double unansweredRate;

responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;

unansweredRate = Q1Results.NumberSurveyed - Q1Results.NumberResponded;

Console.WriteLine($" Response Rate is {responseRate}; Unanswered Rate is:  {unansweredRate}");

Console.ReadKey();

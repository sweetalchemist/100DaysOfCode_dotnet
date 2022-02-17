// See https://aka.ms/new-console-template for more information
using LearningDotNetDemo.Console;

Console.WriteLine("Hello, World!");

for (var i = 0; i < 6; i++)
{
    Console.WriteLine(i.GetType().FullName);
}

var numbers = new int[] { 1, 2, 3, 4, 5, 6 };

var type = numbers.GetType();

while(type != null)
{
    Console.WriteLine(type);
    type = type.BaseType;
}

// Expression Lambda
var sum = numbers.Aggregate(0, (total, x) => total + x);
Console.WriteLine(sum.ToString());

// Linq expression
var expSum = numbers.Aggregate(0, (total, num) => { Console.WriteLine($" Total: {total}, Num: {num}"); return total + num; });
Console.WriteLine(expSum.ToString());

var c1 = new Class1() { MyProperty = 1, MyProperty2 = 2 };  
c1.MyProperty = 3;
//c1.MyProperty2 = 4; <- this is not allowed, since Prop2 is init
Console.WriteLine(c1.ToString());

Console.WriteLine(c1.Sum());

var x = new Person() { YearOfBirth = 1990 }; 
Console.WriteLine(x.GenerationName.ToString());

Console.ReadKey();
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var stack = new SimpleStack();
stack.Push(1.0);
stack.Push(2.0);
stack.Push(2.1);
stack.Push(2.2);
stack.Push(3.1);
stack.Push(5.0);
stack.Push(6.0);


double sum = 0.0;
while(stack.Count > 0)
{
   var item = stack.Pop();
    Console.WriteLine($"Item : {item}");
    sum += item;
}
Console.WriteLine($"Sum : {sum}");

Console.ReadLine();

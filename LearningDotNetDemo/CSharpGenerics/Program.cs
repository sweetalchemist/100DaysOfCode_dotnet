// See https://aka.ms/new-console-template for more information
using CSharpGenerics.Entities;
using CSharpGenerics.Repositories;

Console.WriteLine("Hello, World!");

StackDoubles();
//StackStrings();

//void StackStrings()
//{
//    var stack = new SimpleStack();
//    stack.Push("Iron Man");
//    stack.Push("Captain America");
//    stack.Push("Spiderman");
//}

var employeeRepository = new GenericRepository<Employee>();
employeeRepository.Add(new CSharpGenerics.Entities.Employee() { FirstName = "Adam" });
employeeRepository.Add(new CSharpGenerics.Entities.Employee() { FirstName = "Ben" });
employeeRepository.Add(new CSharpGenerics.Entities.Employee() { FirstName = "Charlie" });
employeeRepository.Save();

var organizationRepository = new GenericRepository<Organization>();
organizationRepository.Add(new CSharpGenerics.Entities.Organization() { Name = "A" });
organizationRepository.Add(new CSharpGenerics.Entities.Organization() { Name = "B" });
organizationRepository.Add(new CSharpGenerics.Entities.Organization() { Name = "C" });
organizationRepository.Save();
 

void StackDoubles()
{
    var stack = new SimpleStack();
    stack.Push(1.0);
    stack.Push(2.0);
    stack.Push(2.1);
    stack.Push(2.2);
    stack.Push(3.1);
    stack.Push(5.0);
    stack.Push(6.0);


    double sum = 0.0;
    while (stack.Count > 0)
    {
        var item = stack.Pop();
        Console.WriteLine($"Item : {item}");
        sum += item;
    }
    Console.WriteLine($"Sum : {sum}");

}

Console.ReadLine();

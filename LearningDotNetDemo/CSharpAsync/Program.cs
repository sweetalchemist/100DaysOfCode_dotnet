Console.WriteLine("Hello World!");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Main Thread: {DateTime.Now.ToString()}");
    var result = await DoSomething();
    Console.WriteLine($"Result :{result}");

}

async Task<string> DoSomething()
{
    Console.WriteLine($"Sub Thread: {DateTime.Now.ToString()}");
    await Task.Run( () => Thread.Sleep(10000));
    return DateTime.Now.ToString();
}

Console.ReadKey();
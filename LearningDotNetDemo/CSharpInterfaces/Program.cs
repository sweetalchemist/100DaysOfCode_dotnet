// See https://aka.ms/new-console-template for more information
using CSharpInterfaces.Library;

Console.WriteLine("Hello, World!");

Tennis tennis = new Tennis("Roger Federer");
DisplayStuff("Tennis", tennis);

BasketBall basketBall = new BasketBall("Seirin High");   
DisplayStuff("Basketball", basketBall);

Cricket cricket = new Cricket("CSK");
DisplayStuff("Cricket", cricket);


void DisplayStuff (string teamType, dynamic team)
{
    try
    {
        Console.WriteLine($"The Team is for {teamType}");
        Console.WriteLine($"The Team Name is : {team.Name}");
        Console.WriteLine($"Number of players : {team.GetNumberOfPlayers()}");
        Console.WriteLine($"Score is calculated in : {team.DoActivity()}");
        Console.WriteLine($"Game is over when : {team.WhenIsGameOver()} ");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.ToString());
    }
}

Console.ReadLine();
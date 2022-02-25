// See https://aka.ms/new-console-template for more information
using CSharpInterfaces.Library;

Console.WriteLine("Hello, World!");

Tennis tennis = new Tennis("Roger Federer");
DisplayStuff("Tennis", tennis);

BasketBall basketBall = new BasketBall("Seirin High");   
DisplayStuff("Basketball", basketBall);

Cricket cricket = new Cricket("CSK");
DisplayStuff("Cricket", cricket);

MusicFactory factory = new MusicFactory();
IMusicPlayer player = factory.CreatePlayer("cassette");
player.CurrentlyPlaying = "Bohemian Rhapsody";
player.Play();

IMusicPlayer player1 = factory.CreatePlayer("streaming");
player1.CurrentlyPlaying = "Hey Jude";
player1.Play();

//IMusicPlayer musicPlayer = factory.CreatePlayer("Podcast");
//musicPlayer.CurrentlyPlaying = "Random Podcast";
//musicPlayer.Play();


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

foreach (var item in GetValues())
{
    Console.WriteLine(item);
}

IEnumerable<int> GetValues()
{
    // Used for returning specific values as an iterator in an IEnumerable (List of) T
    yield return 0;
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
    yield return 5;
}

Console.ReadLine();
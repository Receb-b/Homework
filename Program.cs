using Homework;

List<FootballPlayer> players1 = new () 
{
    new FootballPlayer(4, 188, "Ronald Araujo", 24),
    new FootballPlayer(15, 187, "Andreas Christensen", 27),
    new FootballPlayer(17, 188, "Marcos Alonso", 33),
    new FootballPlayer(18, 170, "Jordi Alba", 34),
    new FootballPlayer(23, 180, "Jules Kounde", 25),
    new FootballPlayer(24, 182, "Eric García", 22),
    new FootballPlayer(5, 189, "Sergio Busquets", 35),
    new FootballPlayer(8, 174, "Pedri", 21),
    new FootballPlayer(19, 183, "Franck Kessie", 27),
    new FootballPlayer(20, 178, "Sergi Roberto", 31),
    new FootballPlayer(30, 173, "Gavi", 19),
};

List<FootballPlayer> players2 = new()
{
    new FootballPlayer(4, 188, "Ronald Araujo", 24),
    new FootballPlayer(15, 187, "Andreas Christensen", 27),
    new FootballPlayer(17, 188, "Marcos Alonso", 33),
    new FootballPlayer(18, 170, "Jordi Alba", 34),
    new FootballPlayer(23, 180, "Jules Kounde", 25),
    new FootballPlayer(24, 182, "Eric García", 22),
    new FootballPlayer(5, 189, "Sergio Busquets", 35),
    new FootballPlayer(8, 174, "Pedri", 21),
    new FootballPlayer(19, 183, "Franck Kessie", 27),
    new FootballPlayer(20, 178, "Sergi Roberto", 31),
    new FootballPlayer(30, 173, "Gavi", 19),
};

Coach coach = new Coach("Alex", 45);

Team team1 = new Team(coach);
team1.AddPlayer(players1);
Team team2 = new Team(coach);
team1.AddPlayer(players2);

Referee referee = new Referee("Mark", 35);

Game game = new Game(team1, team2, referee, 2);

game.Start();

Console.WriteLine("Game Result: " + game.GetResult());
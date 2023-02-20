
using System.Numerics;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using TicTocApp.classes;
using TicTocApp.Utils;

GameStateFactory gameStateFactory = new GameStateFactory();

ArgsParser parser = new ArgsParser();

FileSaverJson saver = new FileSaverJson(gameStateFactory);

Game game = new Game(gameStateFactory);


if (parser.GetParamByName("--load-saved")!=null)
{
    saver.LoadFile();
}

game.Start();

while (true)
{
    
    Console.Write("Enter a number:");
    
    var val = Console.ReadLine();
    
    if (val == "S"||val=="s")
    {
        saver.SaveFile();
        continue;
    }
    if(val =="e"||val=="E")
    {
        Console.WriteLine("Game over");
        break;
    }
    if (val == string.Empty || !int.TryParse(val, out _))
    {
        Console.WriteLine("incorrect input!");
        continue;
    }
    bool res = game.Move(int.Parse(val));
    if (res)
    {
        break;
    }
}
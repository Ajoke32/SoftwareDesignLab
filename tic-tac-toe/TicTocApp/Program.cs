
using System.Numerics;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using TicTocApp.classes;




var game = new Game();

var saver = new FileSaverJson(game);

string[] arguments = Environment.GetCommandLineArgs();

if (arguments.Length>=2&&arguments[1] == "--load-saved")
{
    saver.LoadFile();
}

game.Start();

while (true)
{
    Console.Write("Enter a number:");
    var val = Console.ReadLine();
    if (val == string.Empty)
    {
        break;
    }
    if (val == "S"||val=="s")
    {
        saver.SaveFile();
        continue;
    }
    bool res = game.Move(int.Parse(val));
    if (res)
    {
        break;
    }
}
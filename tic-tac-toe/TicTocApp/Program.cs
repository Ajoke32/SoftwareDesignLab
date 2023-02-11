
using System.Numerics;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using TicTocApp.classes;




var game = new Game();

game.Start();

while (true)
{
    Console.Write("Enter a number:");
    string val = Console.ReadLine();
    if (val == "S"||val=="s")
    {
        game.SaveGame();
        break;
    }
    bool res = game.Move(int.Parse(val), game.currentPlayer.Id);
    if (res)
    {
        break;
    }
}
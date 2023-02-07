
using System.Numerics;
using TicTocApp.classes;

var grid = new Grid();

var game = new Game();

grid.Draw();

game.Start();

while (true)
{
    Console.Write("Enter a number:");
    int val = int.Parse(Console.ReadLine());
    bool res = game.Move(val, game.currentPlayer);
    if (res)
    {
        
        break;
    }
    
}
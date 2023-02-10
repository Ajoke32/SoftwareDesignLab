
using System.Numerics;
using TicTocApp.classes;



var game = new Game();





game.Start();

while (true)
{
    Console.Write("Enter a number:");
    int val = int.Parse(Console.ReadLine());
    bool res = game.Move(val, game.currentPlayer.Id);
    if (res)
    {
        break;
    }
  
    
    
}
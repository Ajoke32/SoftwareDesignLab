using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTocApp.interfaces;

namespace TicTocApp.classes
{
    internal class GameState : IGameState
    {
        public Grid grid { get; set; } = new Grid();
        public Dictionary<int, int> Moves { get; set; } = new Dictionary<int, int>();
        public Player? currentPlayer { get; set; }
    }
}
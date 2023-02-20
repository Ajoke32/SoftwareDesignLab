using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTocApp.classes;

namespace TicTocApp.interfaces
{
    internal interface IGameState
    {
        public Grid grid { get; set; }

        public Dictionary<int, int> Moves { get; set; }

        public Player? currentPlayer { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTocApp.interfaces;

namespace TicTocApp.classes
{
    internal class GameStateFactory
    {
        private GameState _gameState;

        public GameStateFactory()
        {
            _gameState = new GameState();
        }

        public IGameState GetGameState()
        {
            return _gameState;
        }
    }
}

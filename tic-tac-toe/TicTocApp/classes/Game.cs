using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TicTocApp.interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TicTocApp.classes
{
    internal class Game
    {   
 
        private readonly PlayerRepository _repo;

        private char[] Signs = { 'X', 'O' };

        private readonly IGameState _gameState;

        private int[][] combinations = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 },
            new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 3, 6, 9 }, new int[] { 1, 5, 9 }, new int[] { 3, 5, 7 } };

        public Game(GameStateFactory gameStateFactory)
        {
            _gameState = gameStateFactory.GetGameState();
            _repo = new PlayerRepository(new Store());
            _repo.AddPlayer(new Player() { Name = "Player 1", Id = 1 });
            _repo.AddPlayer(new Player() { Name = "Player 2", Id = 2 });
        }
        public void Start()
        {
            _gameState.grid.Draw();
            DisplayGameInfo();
            if (_gameState.currentPlayer == null)
            {
                _gameState.currentPlayer = _repo.GetAllPlayers()[0];
            }
            Console.WriteLine($"\nPlayer {_gameState.currentPlayer.Name} turn");
        }
        public bool Move(int position)
        {

            if (_gameState.Moves.ContainsKey(position) || position > 9)
            {
                Console.WriteLine("Move not accepted, enter valid number!");
                return false;
            }
            if (_gameState.currentPlayer != null)
            {
                _gameState.Moves[position] = _gameState.currentPlayer.Id;
                _gameState.grid.Draw(position, _gameState.currentPlayer.Sign);
                return CheckWin(_gameState.currentPlayer.Id);
            }
            
            return false;
        }
        private bool CheckWin(int playerId)
        {
            foreach (var item in combinations)
            {
                var result = Array.FindAll(item, i => _gameState.Moves.ContainsKey(i)&&_gameState.Moves[i]==playerId);

                if (result.Length == 3)
                {
                    Console.WriteLine($"\nWinner player {_gameState.currentPlayer?.Name}");
                    return true;
                }
            }
            if (_gameState.Moves.Count == 9)
            {
                Console.WriteLine($"\nDraw!");
                return true;
            }

            ChangePlayer(playerId);
            return false;
        }
        private void DisplayGameInfo()
        {
            Console.WriteLine("\nLet's play Tic Tac Toe\n");
            var players = _repo.GetAllPlayers();
            for (int i = 0;i<players.Count;i++)
            {
                players[i].Sign = Signs[i];
                Console.WriteLine($"{players[i].Name}:{players[i].Sign}");
            }
        }
        private int ChangePlayer(int playerId)
        {
            var player = _repo.GetFirstPlayerExceptId(playerId);
            if (player == null)
            {
                return 0;
            }
            _gameState.currentPlayer = player;
            Console.WriteLine($"\n{_gameState.currentPlayer.Name} turn, sign {_gameState.currentPlayer.Sign}");
            return player.Id;
        }
    }
}

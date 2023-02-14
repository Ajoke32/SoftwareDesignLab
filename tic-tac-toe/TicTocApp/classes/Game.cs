using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TicTocApp.classes
{
    public class Game
    {
      
 
        private readonly PlayerRepository _repo;
        private char[] Signs = { 'X', 'O' };
        public Game()
        {
            _repo = new PlayerRepository(new Store());
        }
        public Grid grid { get;set; } = new Grid();

        public int[][] combinations = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 },
            new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 3, 6, 9 }, new int[] { 1, 5, 9 }, new int[] { 3, 5, 7 } };

        public Dictionary<int, int> Moves { get; set; } = new Dictionary<int, int>();

        public Player? currentPlayer { get; set; }
        public void Start()
        {
            grid.Draw();
            _repo.AddPlayer(new Player() {Name="Player 1",Id=1});
            _repo.AddPlayer(new Player() {Name = "Player 2", Id=2});
            DisplayGameInfo();
            if (currentPlayer == null)
            {
                currentPlayer = _repo.GetAllPlayers()[0];
            }
            Console.WriteLine($"\nPlayer {currentPlayer.Name} turn");
        }
        public bool Move(int position)
        {

            if (Moves.ContainsKey(position) || position > 9)
            {
                Console.WriteLine("Move not accepted, enter valid number!");
                return false;
            }
            Moves[position] = currentPlayer.Id;
            grid.Draw(position,currentPlayer.Sign);
            return CheckWin(currentPlayer.Id);
        }
        public bool CheckWin(int playerId)
        {
            foreach (var item in combinations)
            {
                var result = Array.FindAll(item, i => Moves.ContainsKey(i)&&Moves[i]==playerId);

                if (result.Length == 3)
                {
                    Console.WriteLine($"\nWinner player {currentPlayer?.Name}");
                    return true;
                }
            }
            if (Moves.Count == 9)
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
                players[i].Sign = Signs[i];
                Console.WriteLine($"{players[i].Name}:{players[i].Sign}");
            }
        }
        private int ChangePlayer(int playerId)
        {
            var player = _repo.GetNextPlayerAfterId(playerId);
            if (player == null)
            {
                return 0;
            }
            currentPlayer = player;
            Console.WriteLine($"\n{currentPlayer.Name} turn");
            return player.Id;
        }
    }
}

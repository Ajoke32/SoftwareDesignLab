using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TicTocApp.classes
{
    public class Game
    {
        public Player[] players { get;} = { new Player() { Id = 1, Name = "Player 1" }, new Player() { Id = 2, Name = "Player 2" }}; 

        public Grid grid { get;set; } = new Grid();

        private FileSaverJson saver = new FileSaverJson();
        public int[] a { get; set; }
        public int[][] combinations = new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 },
            new int[] { 1, 4, 7 }, new int[] { 2, 5, 8 }, new int[] { 3, 6, 9 }, new int[] { 1, 5, 9 }, new int[] { 3, 5, 7 } };

        public HashSet<int> filledCells { get; set; } = new HashSet<int>();

        public Player currentPlayer { get; set; } = null;
        public void Start()
        {
            grid.Draw();
            Console.WriteLine("\nLet's play Tic Tac Toe\n");
            players[0].Sign = 'X';
            players[1].Sign = 'O';
            Console.WriteLine($"{players[0].Name}: {players[0].Sign}");
            Console.WriteLine($"{players[1].Name}: {players[1].Sign}");
            if (currentPlayer == null)
            {
                currentPlayer = players[0];
            }
            Console.WriteLine($"\nPlayer {currentPlayer.Name} turn");
        }

        public void LoadGame()
        {
            var info = saver.GetFile();
            grid = info.grid;
            currentPlayer = info.currentPlayer;
            filledCells = info.filledCells;
        }
        public bool Move(int position, int playerId)
        {

            if (filledCells.Contains(position) || position > 9)
            {
                Console.WriteLine("Move not accepted, Enter valid number!");
                return false;
            }
            filledCells.Add(position);
            var player = players.FirstOrDefault(p => p.Id == playerId);
            player.Moves.Add(position, true);
            grid.Draw(position,currentPlayer.Sign);
            return CheckWin(playerId);
        }
        public bool CheckWin(int playerId)
        {
            var player = players.FirstOrDefault(p => p.Id == playerId);
            if (player == null)
            {
                return false;
            }
            
            foreach (var item in combinations)
            {
                var result = Array.FindAll(item, i => player.Moves.ContainsKey(i)==true);
                if (result.Length == 3)
                {
                    Console.WriteLine($"\nWinner player {currentPlayer.Name}");
                    return true;
                }
                if (filledCells.Count == 9 && result.Length != 3)
                {
                    Console.WriteLine($"\nDraw!");
                    return true;
                }
            }

            ChangeMoves(playerId);
            return false;
        }


        private int ChangeMoves(int id)
        {
            var player = players.FirstOrDefault(p => p.Id != id);
            if (player == null)
            {
                return 0;
            }
            currentPlayer = player;
            Console.WriteLine($"\n{currentPlayer.Name} turn");
            return player.Id;
        }
        public void ChangePlayers()
        {
            Array.Reverse(players);
        }

        public void SaveGame()
        {
            saver.SaveFile(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocApp.classes
{
    public class Game
    {
        private Player[] players = { new Player() { Id = 1, Name = "Player 1" }, new Player() { Id = 2, Name = "Player 1" } };
       
        public int[,] combinations = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 1, 4, 7 }, { 2, 5, 8 }, { 3, 6, 9 }, { 1, 5, 9 }, { 3, 5, 7 } };
        private Queue<int> checkedPos = new Queue<int>();
        public int currentPlayer = 0;
        public void Start()
        {
            Console.WriteLine("Let's play Tic Tac Toe\n");
            Console.WriteLine($"{players[0].Name}: X");
            Console.WriteLine($"{players[1].Name}: O");
            currentPlayer = players[0].Id;
            Console.WriteLine($"Player {currentPlayer} turn");
        }
        public bool Move(int position, int playerId)
        {
           
            if (checkedPos.Contains(position)||position>9)
            {
                Console.WriteLine("Move not accepted, Enter valid number!");
                return false;
            }
            checkedPos.Enqueue(position);
            var player = players.FirstOrDefault( p => p.Id == playerId );
            player.Moves.Push(position);
            return CheckWin(playerId);
        }
        public bool CheckWin(int playerId)
        {
            var player = players.FirstOrDefault(p => p.Id == playerId);
            if (player==null)
            {
                return false;
            }
            for (int i = 0; i < 8; i++)
            {
                int count = 0;
                for (int j = 0; j < 3; j++)
                {
                    if (player.Moves.Contains(combinations[i, j]))
                    {
                        count++;
                    }
                }
                if (count == 3)
                {
                    Console.WriteLine($"Player {currentPlayer} win");
                    return true;
                }
                count = 0;
            }

            ChangeMoves(playerId);
            return false;
        }


        private int ChangeMoves(int id)
        {
            var player = players.FirstOrDefault(p => p.Id == id);
           
            if (player == null)
            {
                return 0;
            }
            foreach (var item in players)
            {
                if (item.Id != player.Id)
                {
                    currentPlayer = item.Id;
                }
            }

            Console.WriteLine($"Player {currentPlayer} turn");
            return player.Id;
        }
        public void ChangePlayers()
        {
            Array.Reverse(players);
        }
    }
}

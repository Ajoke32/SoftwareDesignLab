using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocApp.classes
{
    public class Grid
    {

        private char[] grid = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public void Draw(int position = 0, char playerSign = 'n')
        {
            Console.Clear();
            for (int i = 0; i < grid.Length; i++)
            {

                char sign = Char.Parse(i.ToString());
                if(position> 0 && i == position - 1)
                {
                    sign = playerSign;
                    grid[i] = sign;
                }
                if ((i+1) % 3 == 0)
                {
                    Console.Write($" {grid[i]}");
                    Console.WriteLine("\n---+---+---");
                }
                else
                {
                    Console.Write($" {grid[i]} |");
                }
            }
        }

    }
}

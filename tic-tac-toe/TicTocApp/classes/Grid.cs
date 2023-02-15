using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocApp.classes
{
    public class Grid
    {

        public char[] cells { get; set; } = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public void Draw(int position = 0, char playerSign = 'n')
        {
            Console.Clear();
            for (int i = 0; i < cells.Length; i++)
            {
                if (position > 0 && i == position - 1)
                {
                    cells[i] = playerSign;
                }
                if ((i + 1) % 3 == 0)
                {
                    Console.Write($" {cells[i]}");
                    Console.WriteLine("\n---+---+---");
                }
                else
                {
                    Console.Write($" {cells[i]} |");
                }
            }
        }

    }
}

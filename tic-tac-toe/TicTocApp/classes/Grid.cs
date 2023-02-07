using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocApp.classes
{
    public class Grid
    {
        public int Rows { get; set; } = 3;
        public int Cols { get; set; } = 3;
        public void Draw()
        {
            for (int i = 1; i <= Rows*Cols; i++)
            {
             
                if (i % 3 == 0)
                {
                    Console.Write($" {i}");
                    Console.WriteLine("\n---+---+---");
                }
                else
                {
                    Console.Write($" {i} |");
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocApp.classes
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Stack<int> Moves { get; set; } = new Stack<int>();

        public void TestData()
        { 
            for(int i=1;i<=2;i++)
            {
                Moves.Push(i);
            }
        }  
        
    }
}

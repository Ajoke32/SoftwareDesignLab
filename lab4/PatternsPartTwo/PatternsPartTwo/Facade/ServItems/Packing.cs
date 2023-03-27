using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Facade.ServItems
{
    internal class Packing
    {
        public string Message { get; set; } = "Thank you for you order :)";
        private void PrintPacking()
        {
            Console.WriteLine("\\------------------------------------------------/\n" +
                $"            {Message}\n"+
                "\\------------------------------------------------/");
        }
        private void ResetMessage()
        {
            Message = "Thank you for you order :)";
        }
        private void GetPackingColor(string name)
        {
          switch (name)
            {
                case "green": Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "yellow": Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                default: Console.WriteLine("Packing not exist");
                    break;
            }  
        }
        private void Reset()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void StartPacking(string color)
        {
            GetPackingColor(color);
            PrintPacking();
            Reset();
            ResetMessage();
        }
        public void EndPacking(string color)
        {
            GetPackingColor(color);
            PrintPacking();
            Reset();
            ResetMessage();
            Console.WriteLine("\n");
        }
    }
}

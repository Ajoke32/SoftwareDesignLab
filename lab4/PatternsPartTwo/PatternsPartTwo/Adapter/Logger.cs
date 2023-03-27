using PatternsPartTwo.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Adapter
{
    internal class Logger :ILogger
    {
        public string Message { get; set; } = "Simple sentence";
        public virtual void Log()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Prompt: {Message}");
            Reset();
        }
        private  void Reset()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }
        public virtual void Error()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Erorr: {Message}");
            Reset();
        }

        public virtual void Warn()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Warning: {Message}");
            Reset();
        }
    }
}

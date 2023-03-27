using PatternsPartTwo.Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Adapter
{
    internal class FileLogger : ILogger
    {
        public void Error()
        {
            ExplainLine("凸(⊙▂⊙✖ )");
            FileWriter.WriteLine("An erorr occurred ");
            ExplainLine("凸(⊙▂⊙✖ )");
        }

        private void ExplainLine(string line)
        {
            FileWriter.WriteLine($"\n-----------------------{line}-----------------------\n");
        }
        public void Log()
        {
            ExplainLine("(＊◕ᴗ◕＊)");
            FileWriter.WriteLine("Best way do this it`s....");
            ExplainLine("(＊◕ᴗ◕＊)");
        }

        public void Warn()
        {
            ExplainLine("Σ(‘◉⌓◉’)");
            FileWriter.WriteLine("An warning occurred");
            ExplainLine("Σ(‘◉⌓◉’)");
        }
    }
}

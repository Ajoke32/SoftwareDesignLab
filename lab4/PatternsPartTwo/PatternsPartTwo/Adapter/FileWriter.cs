using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Adapter
{
    internal class FileWriter
    {
        private static string _path = $"{Directory.GetCurrentDirectory()}/Logs.txt";
        public static void Write(string message)
        {
            File.AppendAllText(_path, message);
        }

        public static void WriteLine(string message)
        {
            File.AppendAllText(_path,$"{message}\n");
        }
    }
}

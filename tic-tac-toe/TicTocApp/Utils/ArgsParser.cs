using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocApp.Utils
{
    internal class ArgsParser
    {
        private string[] _args;
        public ArgsParser()
        {
            _args = Environment.GetCommandLineArgs();
        }

        public string? GetParamByName(string name)
        {
            return _args.FirstOrDefault(i => i == name);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Adapter.Interfaces
{
    internal interface ILogger
    {
        public void Log();

        public void Error();

        public void Warn();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsPartTwo.Adapter
{
    internal class FileLoggerAdapter : Logger
    {
        private FileLogger _logger;
        public FileLoggerAdapter(FileLogger logger)
        {
            _logger = logger;
        }

        public override void Log()
        {
            _logger.Log();
        }

        public override void Error()
        {
            _logger.Error();
        }

        public override void Warn()
        {
            _logger.Warn();
        }
    }
}

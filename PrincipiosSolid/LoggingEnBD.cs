using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid
{
    public class LoggingEnBD : ILogging 
    {
        private readonly LoggingRepository _logRepo;
        private readonly ILogging _log;
        public LoggingEnBD(LoggingRepository logRepo, ILogging log)
        {
            _logRepo = logRepo;
            _log = log;
        }
        public void Fatal(string message, Exception e)
        {
            _logRepo.AlmacenarEnBD(message, e);
            _log.Fatal(message, e);
        }

    }
}

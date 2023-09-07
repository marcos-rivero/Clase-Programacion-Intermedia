using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiosSolid
{
    public class Logging : ILogging
    {
        public void Info(string message)
        {
            Log.Information(message);
        }
        public void Error(string message, Exception e)
        {
            Log.Error(e, message);
        }
        public void Fatal(string message, Exception e)
        {
            Log.Fatal(e, message);
        }
    }
}

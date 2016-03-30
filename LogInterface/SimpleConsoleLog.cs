using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInterface
{
    public class SimpleConsoleLog : ILog
    {
        public void LogDebug(String msg)
        {
            Console.WriteLine("DEBUG | "+msg);
        }
    }
}

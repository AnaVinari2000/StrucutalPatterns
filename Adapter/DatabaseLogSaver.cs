using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class DatabaseLogSaver : ILogSaver
    {
        public void SaveLog(Log log)
        {
            Console.WriteLine($"Saving log do DB. {log.LoggedAt} {log.Message} ");
        }

        public void SaveErrorLog(Log log)
        {
            Console.WriteLine($"Saving error log to DB. {log.LoggedAt} {log.Message} {log.ErrorStackTrace}");
        }
    }
}

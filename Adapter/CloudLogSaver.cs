using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CloudLogSaver
    {
        public void Save(DateTime loggedAt, string message)
        {
            Console.WriteLine($"Saving log to Cloud. {loggedAt} {message}");
        }

        public void SaveException(DateTime loggedAt, string message, string error)
        {
            Console.WriteLine($"Saving error log to Cloud. {loggedAt} {message} {error}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class CloudLogSaverAdapter : ILogSaver
    {

        private readonly CloudLogSaver _cloudLogSaver = new CloudLogSaver();

        public void SaveLog(Log log)
        {
            _cloudLogSaver.Save(log.LoggedAt, log.Message);
        }

        public void SaveErrorLog(Log log)
        {
            _cloudLogSaver.SaveException(log.LoggedAt, log.Message, log.ErrorStackTrace);
        }
    }
}

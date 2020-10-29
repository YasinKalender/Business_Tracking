using Business_Tracking.Business.Abstract;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business_Tracking.Business.CustomLogger
{
    public class NLogLogger : ICustomLogger
    {
        public void LogError(string mesaj)
        {
            var logger = LogManager.GetLogger("Logger");
            logger.Log(LogLevel.Error,mesaj);
        }
    }
}

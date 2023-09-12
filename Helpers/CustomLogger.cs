using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Helpers
{
    public static partial class CustomLogger
    {
        //Info: could be globally usable
        // private static readonly Action<ILogger, string, Exception?> loggerMessage =
        // LoggerMessage.Define<string>(
        //     LogLevel.Critical,
        //     new EventId(13, nameof(CustomLogger)),
        //     "Performance log: {message}");
        public static void PerformanceLog(this ILogger logger, string message)
        {
            Action<ILogger, string, Exception?> loggerMessage =
        LoggerMessage.Define<string>(
            LogLevel.Critical,
            new EventId(13, nameof(CustomLogger)),
            "Performance log: {message}");
            loggerMessage(logger, message, null);
        }

        [LoggerMessage(EventId = 13, Level = LogLevel.Error, Message = "Generated Performance log: {message}")]
        public static partial void GeneratedPerformanceLog(this ILogger logger, string message);


    }
}
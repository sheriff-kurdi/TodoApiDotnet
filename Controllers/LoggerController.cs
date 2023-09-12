using Microsoft.AspNetCore.Mvc;
using TodoApi.Helpers;

namespace TodoApi.Controllers
{
    public class LoggerController
    {
        public static async Task<IResult> LogAsync([FromServices] ILogger<LoggerController> logger)
        {
            logger.PerformanceLog("message for the log!!!");
            logger.GeneratedPerformanceLog("message for the log!!!");
            throw new Exception("manual exception");
            return Results.Ok("Hello Dotnet From High Performance Logging");

        }

    }
}
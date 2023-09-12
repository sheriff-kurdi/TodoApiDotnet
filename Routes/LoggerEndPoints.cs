using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoApi.Controllers;

namespace TodoApi.Routes
{
    public static class LoggerEndPoints
    {
        public static void UseLoggerEndPoints(this WebApplication app)
        {
            RouteGroupBuilder stockGroup = app.MapGroup("/api/v1/logger").WithTags("Logger");


            stockGroup.MapGet("/", LoggerController.LogAsync);
   

        }
    }
}
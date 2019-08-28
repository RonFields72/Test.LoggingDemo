using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Test.LoggingDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger _logger;

        //// standard way of capturing the loggger category
        //public IndexModel(ILogger<IndexModel> logger)
        //{
        //    _logger = logger;
        //}

        public IndexModel(ILoggerFactory factory)
        {
            _logger = factory.CreateLogger("DemoCategory");
        }
        public void OnGet()
        {
            _logger.LogTrace("This is a trace log");
            _logger.LogDebug("This is a debug log");
            _logger.LogInformation(LoggingId.DemoCode, "I made this my 1st logged message :)");
            _logger.LogWarning("THIS IS A WARNING!!!");
            _logger.LogError("This is a log from an ERROR.");
            _logger.LogCritical("This is a critical log, man! You better do something quick!");

            // these are advanced logging messages
            //_logger.LogError("The server crashed at {Time}", DateTime.UtcNow);

            //try
            //{
            //    throw new Exception("This is a custom exception that I am catching");
            //}
            //catch (Exception why)
            //{
            //    _logger.LogCritical(why, "Something really bad happened at {Time}", DateTime.UtcNow);
            //}


        }
    }
}

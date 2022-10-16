using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Serilog.Demo.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> logger)
        {
            this.logger = logger;
        }
        
        public string Get()
        {
            this.logger.LogInformation("Default route has been called.");
            
            this.logger.LogWarning("This route is not doing anything than logging.");
            
            this.logger.LogError(new Exception("Sample Exception"), "This is a sample error log.");
            
            return "Hello Serilog Demo!";
        }
    }   
}
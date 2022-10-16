using Microsoft.AspNetCore.Mvc;

namespace Serilog.Demo.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public string Get()
        {
            return "Hello Serilog Demo!";
        }
    }   
}
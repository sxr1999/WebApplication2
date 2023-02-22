using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Xml;


namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly IWebHostEnvironment _env;

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _env = env;
        }

       

        [HttpGet]
        public IActionResult Get()
        {
            if (_env.IsDevelopment())
            {
                var path = Path.Combine(_env.ContentRootPath, "appsettings.Development.json");
                string json = System.IO.File.ReadAllText(path);
                object jsonObject = JsonConvert.DeserializeObject(json);
                return Ok(jsonObject);
            }else if (_env.IsProduction())
            {
                //read from appsettings.Production.json
                return Ok();
            }
            else
            {
                //..........
                return Ok();
            }

            
        }
    }
    
}
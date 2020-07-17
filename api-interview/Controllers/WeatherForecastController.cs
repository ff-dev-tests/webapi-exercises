using System;
using System.Collections.Generic;
using System.Linq;
using api_interview.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api_interview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Temperature> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 2).Select(x =>
                new Temperature(rng.NextDouble(), DateTime.Now))
                    .ToArray();
        }
    }
}

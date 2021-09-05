using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Nlog.API.Controllers
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
		public IEnumerable<string> Get()
		{
			_logger.LogDebug("This is a debug message");
			_logger.LogInformation("This is an info message");
			_logger.LogWarning("This is a warning message ");
			_logger.LogError(new Exception(), "This is an error message");

			return new string[] { "Cool", "Weather" };

		}
	}
}


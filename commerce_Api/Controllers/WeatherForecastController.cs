using commerce_Api.MODEL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace commerce_Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        StudentContent stuContent;
        /// <summary>
        /// 依赖注入
        /// </summary>
        /// <param name="stuContent"></param>
        public WeatherForecastController(StudentContent studentContent)
        {
           this.stuContent = studentContent;
        }
      
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Student> GetStudentList()
        {
            return stuContent.students.ToList();
        }
    }
}

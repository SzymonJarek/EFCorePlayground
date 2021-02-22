using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePlayGroundd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly AppDbContext _context;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //var b = new Domain.Entity.Book { Rating = 5, Title = "Andrzej St" };
            //try
            //{
            //    _context.Books.Add(new Domain.Entity.Book { Rating = 5, Title = "Andrzej St" });
            //}
            //catch (Exception ex)
            //{

            //}
            //var res = await _context.SaveChangesAsync();

            //var dupa = await _context.Books.FindAsync(1);
            ////var dupa1 = _context.Books.SingleOrDefault(x => x.Id == 14);
            ////var dupa2 = _context.Books.SingleOrDefault(x => x.Id == 15);

            //if (res > 0)
            //    return Ok();
            //else
                throw new Exception();

        }
    }
}

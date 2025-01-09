using DockerLibrary;
using Microsoft.AspNetCore.Mvc;

namespace DockerWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServiceController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ServiceController> _logger;

        public ServiceController(ILogger<ServiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet("weather", Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> GetWeather()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpGet("users")]
        public IActionResult GetUsers()
        {
            var users = new Users[]
            {
                new Users{ Id = 1, Name = "Ahmet Yılmaz", Email = "ahmet@example.com", Age = 30 },
                new Users{ Id = 2, Name = "Ayşe Demir", Email = "ayse@example.com", Age = 25 },
                new Users{ Id = 3, Name = "Mehmet Kaya", Email = "mehmet@example.com", Age = 35 }
            };

            return Ok(users);
        }

        [HttpGet("products")]
        public IActionResult GetProducts()
        {
            var products = new[]
            {
                new { Id = 1, Name = "Laptop", Price = 15000.00m, Category = "Electronics", Stock = 50 },
                new { Id = 2, Name = "Smartphone", Price = 8000.00m, Category = "Electronics", Stock = 100 },
                new { Id = 3, Name = "Headphones", Price = 1000.00m, Category = "Accessories", Stock = 200 }
            };

            return Ok(products);
        }

        [HttpGet("orders")]
        public IActionResult GetOrders()
        {
            var orders = new[]
            {
                new {
                    OrderId = 1,
                    CustomerName = "Ali Yıldız",
                    OrderDate = DateTime.Now.AddDays(-5),
                    Items = new[]
                    {
                        new { ProductId = 1, ProductName = "Laptop", Quantity = 1, Price = 15000.00m },
                        new { ProductId = 3, ProductName = "Headphones", Quantity = 2, Price = 1000.00m }
                    },
                    TotalAmount = 17000.00m
                },
                new {
                    OrderId = 2,
                    CustomerName = "Zeynep Çelik",
                    OrderDate = DateTime.Now.AddDays(-2),
                    Items = new[]
                    {
                        new { ProductId = 2, ProductName = "Smartphone", Quantity = 1, Price = 8000.00m }
                    },
                    TotalAmount = 8000.00m
                }
            };

            return Ok(orders);
        }
    }
}

using Animals.Models;
using Microsoft.AspNetCore.Mvc;

namespace Animals.Controllers;

[ApiController]
[Route("[controller]")]
public class AnimalController : ControllerBase
{
    private readonly ILogger<AnimalController> _logger;

    public AnimalController(ILogger<AnimalController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetAnimal")]
    public IEnumerable<Animal> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Animal
        {
            
        })
        .ToArray();
    }
}

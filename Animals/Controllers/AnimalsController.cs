using Animals.Data;
using Animals.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Animals.Controllers;

[ApiController]
[Route("api/animals")]
public class AnimalsController : ControllerBase
{
    private static IAnimalsRepository _animalsRepositoryService = new AnimalsRepository();

    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(_animalsRepositoryService.GetAnimals());
    }
}

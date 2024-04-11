using Animals.Data;
using Animals.Models;
using Microsoft.AspNetCore.Mvc;

namespace Animals.Controllers;

[ApiController]
[Route("api/animals")]
public class AnimalsController : ControllerBase
{
    private static List<Animal> _animalsRepositoryService = AnimalsRepository.GetAll();

    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(_animalsRepositoryService);
    }

    [HttpGet("{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var animal = _animalsRepositoryService.FirstOrDefault(a => a.Id == id);
        if (animal == null)
        {
            return NotFound($"Animal {id} not found");
        }

        return Ok(animal);
    }

    [HttpPost]
    public IActionResult CreateAnimal(Animal animal)
    {
        _animalsRepositoryService.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }

    [HttpPut("{id:int}")]
    public IActionResult EditAnimal(int id, Animal animal)
    {
        var animalToEdit = _animalsRepositoryService.FirstOrDefault(a => a.Id == id);
        if(animalToEdit == null)
        {
            return NotFound($"Animal {id} not found");
        }
        _animalsRepositoryService.Remove(animalToEdit);
        _animalsRepositoryService.Add(animal);

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animalToEdit = _animalsRepositoryService.FirstOrDefault(a => a.Id == id);
        if(animalToEdit == null)
        {
            return NoContent();
        }
        _animalsRepositoryService.Remove(animalToEdit);

        return NoContent();

    }
}

using Animals.Data;
using Animals.Models;
using Microsoft.AspNetCore.Mvc;

namespace Animals.Controllers;

[Route("api/visits")]
[ApiController]
public class VisitsController : ControllerBase
{
    private static List<Visit> _visitsRepositoryService = VisitsRepository.GetAll();

    private static List<Animal> _animalsRepositoryService = AnimalsRepository.GetAll();

    [HttpGet("{animalID:int}")]
    public IActionResult GetVisitsForAnimal(int animalID)
    {
        var visits = _visitsRepositoryService.FindAll(v => v.IdAnimal == animalID);
        if (!visits.Any())
        {
            return NotFound($"There are no visits for animal {animalID}");
        }
        return Ok(visits);
    }

    [HttpPost]
    public IActionResult VisitCreate(Visit visit)
    {
        if (_animalsRepositoryService.FirstOrDefault(a => a.Id == visit.IdAnimal) == null)
        {
            return NotFound($"There is no visit for animal {visit.IdAnimal}");
        }
        _visitsRepositoryService.Add(visit);
        return NoContent();
    }

    
    
}
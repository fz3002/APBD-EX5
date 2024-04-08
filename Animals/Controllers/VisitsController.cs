using Animals.Data;
using Animals.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Animals.Controllers;

[Route("api/visits")]
[ApiController]
public class VisitsController : ControllerBase
{

    private static IVisitsRepository _visits = new VisitsRepository();
    
}
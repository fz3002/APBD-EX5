using Animals.Models;

namespace Animals.Data;

public static class VisitsRepository
{
    private static List<Visit> _visits = [
        new Visit { Date = DateTime.Now.AddDays(-7), IdAnimal = 1, Summary = "Routine checkup", Price = 50.00f },
        new Visit { Date = DateTime.Now.AddDays(-3), IdAnimal = 2, Summary = "Vaccination", Price = 80.00f },
        new Visit { Date = DateTime.Now.AddMonths(-1), IdAnimal = 1, Summary = "Treatment for illness", Price = 120.00f },
    ];
    
    public static List<Visit> GetAll()
    {
        return _visits;
    }
}
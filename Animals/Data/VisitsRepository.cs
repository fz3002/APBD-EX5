using Animals.Models;

namespace Animals.Data;

public static class VisitsRepository
{
    private static List<Visit> _visits = new List<Visit>();
    
    public static List<Visit> GetAll()
    {
        return _visits;
    }
}
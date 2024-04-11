namespace Animals.Data;

using System.Collections.Generic;
using Animals.Models;

public static class AnimalsRepository
{

    private static List<Animal> _animals = new List<Animal>();
    public static List<Animal> GetAll()
    {
        return _animals;
    }
}
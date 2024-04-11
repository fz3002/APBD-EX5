namespace Animals.Data;

using System.Collections.Generic;
using Animals.Models;

public static class AnimalsRepository
{

    private static List<Animal> _animals = [
        new Animal { Id = 0, Name = "Fafik", Category = Enums.Categories.Dog, Mass = 15f, Color_of_fur = "Yellow" },
            new Animal { Id = 1, Name = "Reksio", Category = Enums.Categories.Dog, Mass = 10f, Color_of_fur = "White" },
            new Animal { Id = 2, Name = "Rudy", Category = Enums.Categories.Dog, Mass = 3f, Color_of_fur = "Red" },
    ];
    public static List<Animal> GetAll()
    {
        return _animals;
    }
}
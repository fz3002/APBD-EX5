using Animals.Enums;

namespace Animals.Models;

public class Animal
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required Categories Category { get; set; }

    public required float Mass { get; set; }
    
    public required string Color_of_fur { get; set; }
}

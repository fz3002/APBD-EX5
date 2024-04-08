namespace Animals.Models;

public class Animal
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public required string Category { get; set; }

    public required string Mass { get; set; }
    
    public required string Color_of_fur { get; set; }
}

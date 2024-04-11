namespace Animals.Models;
public class Visit
{
    public DateTime Date { get; set; }

    public required int IdAnimal { get; set; }

    public required string Summary { get; set; }

    public float Price { get; set; }
    
}
namespace Animals.Models;
public class Visit
{
    public DateTime Date { get; set; }

    public required Animal Animal_Visiting { get; set; }

    public required string Summary { get; set; }

    public float Price { get; set; }
    
}
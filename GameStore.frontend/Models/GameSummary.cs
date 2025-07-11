using System;

namespace GameStore.frontend.Models;

public class GameSummary
{

    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Genre { get; set; }
    public required decimal Price { get; set; }
    public DateOnly ReleaseDate { get; set; }
    
}

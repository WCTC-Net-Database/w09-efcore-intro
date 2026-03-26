namespace W09.Models;

public class Room
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    // Navigation property to Characters
    public virtual ICollection<Character> Characters { get; set; } = new List<Character>();
}
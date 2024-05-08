namespace DigitalMatterPracticalExercise.Models;

public class Group
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public int? ParentGroupId { get; set; }

    public ICollection<Connection> Connections { get; set; }

    public Group ParentGroup { get; set; }
}

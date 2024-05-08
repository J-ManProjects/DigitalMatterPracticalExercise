namespace DigitalMatterPracticalExercise.Models;

public class Device
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public ICollection<Connection> Connections { get; set; }
    public ICollection<Firmware> Firmware { get; set; }
}

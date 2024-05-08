using System.ComponentModel.DataAnnotations;

namespace DigitalMatterPracticalExercise.Models;

public class Firmware
{
    public int Id { get; set; }

    public string Version { get; set; } = string.Empty;

    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    public string? Description { get; set; }

    public int? DeviceId { get; set; }

    public Device Device { get; set; }
}

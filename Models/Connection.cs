﻿namespace DigitalMatterPracticalExercise.Models;

public class Connection
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int DeviceId { get; set; }

    public Group Group { get; set; }
    public Device Device { get; set; }
}

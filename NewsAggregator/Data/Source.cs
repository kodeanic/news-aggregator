﻿namespace NewsAggregator.Data;

public class Source
{
    public int Id { get; set; }
    public string Title { get; set; } = null!;
    public bool IsPicked { get; set; } = true;
    public string Link { get; set; } = null!;
}

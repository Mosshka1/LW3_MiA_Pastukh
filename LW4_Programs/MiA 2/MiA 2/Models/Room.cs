﻿namespace Models;

public class Room
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Capacity { get; set; }
    public bool Active { get; set; } = true;
}

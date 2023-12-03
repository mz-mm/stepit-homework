﻿namespace FactoryMethod.Models;

public class Truck : IAutomobile
{
    public string Model { get; set; }
    public string Mark { get; set; }
    public DateTime Year { get; set; }
}
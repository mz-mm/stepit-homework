﻿using AbstractFactory.Models;

namespace AbstractFactory.Entities.BaseFurniture.Interfaces;

public interface IFurniture
{
    public string Model { get; set; }
    public string Material { get; set; }
    public ItemAttributes FurnitureAttributes { get; set; }
}
using System;
using System.Collections.Generic;
abstract class Vehicle
{
    public int Speed { get; set; }
    public int Capacity { get; set; }

    // Абстрактний метод Move
    public abstract void Move();
}
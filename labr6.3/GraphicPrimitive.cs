using System;
using System.Collections.Generic;

// Абстрактний клас GraphicPrimitive
abstract class GraphicPrimitive
{
    public int X { get; set; }
    public int Y { get; set; }

    public abstract void Draw();
    public abstract void Move(int x, int y);

    // Метод для масштабування
    public abstract void Scale(float factor);
}
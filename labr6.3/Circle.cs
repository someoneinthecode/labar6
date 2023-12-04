class Circle : GraphicPrimitive
{
    public int Radius { get; set; }

    public override void Draw()
    {
        Console.WriteLine($"Drawing Circle at ({X}, {Y}) with radius {Radius}");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
        Console.WriteLine($"Moving Circle to ({X}, {Y})");
    }

    public override void Scale(float factor)
    {
        Radius = (int)(Radius * factor);
        Console.WriteLine($"Scaling Circle to radius {Radius}");
    }
}
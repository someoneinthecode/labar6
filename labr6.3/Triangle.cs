class Triangle : GraphicPrimitive
{
    public override void Draw()
    {
        Console.WriteLine($"Drawing Triangle at ({X}, {Y})");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
        Console.WriteLine($"Moving Triangle to ({X}, {Y})");
    }

    public override void Scale(float factor)
    {
        Console.WriteLine($"Scaling Triangle by factor {factor}");
    }
}
class Program
{
    static void Main()
    {
        // Приклад використання класів
        Circle circle = new Circle { X = 10, Y = 20, Radius = 5 };
        Rectangle rectangle = new Rectangle { X = 30, Y = 40, Width = 8, Height = 6 };
        Triangle triangle = new Triangle { X = 50, Y = 60 };

        GraphicsEditor editor = new GraphicsEditor();
        editor.AddPrimitive(circle);
        editor.AddPrimitive(rectangle);
        editor.AddPrimitive(triangle);

        Console.WriteLine("Initial state:");
        editor.DrawAll();

        editor.MoveAll(5, 5);
        Console.WriteLine("\nAfter moving:");
        editor.DrawAll();

        editor.ScaleAll(2);
        Console.WriteLine("\nAfter scaling:");
        editor.DrawAll();

        // Додавання групи
        Group group = new Group { X = 80, Y = 90 };
        group.AddPrimitive(circle);
        group.AddPrimitive(rectangle);
        editor.AddPrimitive(group);

        editor.MoveAll(10, 10);
        Console.WriteLine("\nAfter moving the entire editor:");
        editor.DrawAll();
    }
}
